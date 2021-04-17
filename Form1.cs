using FindMatch.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMatch
{
    public partial class Form1 : Form
    {
        private DateTime? _startTime;
        private List<int> _randomNumbersOfImages12; // все номера картинок на поле
        private List<int> _openedButtons;
        private readonly List<Button> _buttons;
        private int _lastButtonContains; // содержимое последней открытой кнопки
        private int _lastButtonNumber; // номер последней открытой кнопки
        private readonly List<Bitmap> _images;
        private readonly List<Bitmap> _imagesGray;
        private List<Button> _temporaryGray; // временно серые кнопки
        private List<int> _permanentGray;
        private List<PictureBox> _miniImages;
        private List<int> _randomNumbersOfImages6;

        public Form1()
        {
            InitializeComponent();

            _miniImages = new List<PictureBox>
            {
                pictureBoxMini1,
                pictureBoxMini2,
                pictureBoxMini3,
                pictureBoxMini4,
                pictureBoxMini5,
                pictureBoxMini6
            };

            _buttons = new List<Button>
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12
            };

            _images = new List<Bitmap>
            {
                Resources._1,
                Resources._2,
                Resources._3,
                Resources._4,
                Resources._5,
                Resources._6,
                Resources._7,
                Resources._8,
                Resources._9,
                Resources._10,
                Resources._11,
                Resources._12,
                Resources._13,
                Resources._14,
                Resources._15,
                Resources._16,
                Resources._17,
                Resources._18,
                Resources._19,
                Resources._20
            };

            _imagesGray = new List<Bitmap>
            {
                Resources.gray1,
                Resources.gray2,
                Resources.gray3,
                Resources.gray4,
                Resources.gray5,
                Resources.gray6,
                Resources.gray7,
                Resources.gray8,
                Resources.gray9,
                Resources.gray10,
                Resources.gray11,
                Resources.gray12,
                Resources.gray13,
                Resources.gray14,
                Resources.gray15,
                Resources.gray16,
                Resources.gray17,
                Resources.gray18,
                Resources.gray19,
                Resources.gray20
            };

            Start();
        }

        public void Start()
        {
            labelTimer.Text = "начните игру!";
            _startTime = null;

            _openedButtons = new List<int>();
            _permanentGray = new List<int>();
            _temporaryGray = new List<Button>();

            _randomNumbersOfImages6 = GenerateArray6();
            _randomNumbersOfImages12 = GenerateMixedArray12(_randomNumbersOfImages6);
            SetMiniGrayImages();

            labelStep.Text = "0";
        }

        public void SetMiniGrayImages()
        {
            for (int i = 0; i < _randomNumbersOfImages6.Count; i++)
            {
                int imageNumber = _randomNumbersOfImages6[i];
                SetMiniGrayImage(i, imageNumber);
            }
        }

        public void SetMiniGrayImage(int key6, int imageNumber)
        {
            _miniImages[key6].Image = _imagesGray[imageNumber - 1];
        }

        public void SetMiniColorImage(int imageNumber)
        {
            foreach (PictureBox miniImage in _miniImages)
            {
                if (miniImage.Image.Equals(_imagesGray[imageNumber - 1]))
                {
                    miniImage.Image = _images[imageNumber - 1];
                }
            }
        }

        public static int GenerateRandom()
        {
            Random rnd = new Random();

            return rnd.Next(1, 20);
        }

        public static void Shuffle(List<int> data)
        {
            Random random = new Random();

            for (int i = data.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = data[j];
                data[j] = data[i];
                data[i] = temp;
            }
        }

        public static List<int> GenerateArray6()
        {
            List<int> tableArray = new List<int>(); // создаем целочисленный массив из 6 элементов

            while (tableArray.Count < 6) // создаем цикл, пока элементов в массиве не станет 6
            {
                //Получить очередное случайное число
                int randomInt = GenerateRandom();

                // если случайное число отсутствует в массиве то добавляем его 1 раз в массив
                if (!tableArray.Contains(randomInt))
                {
                    tableArray.Add(randomInt);
                }

            }

            return tableArray;

        }

        public static List<int> GenerateMixedArray12(List<int> tableArray6)
        {
            List<int> tableArray12 = new List<int>();

            foreach (int i in tableArray6)
            {
                tableArray12.Add(i);
                tableArray12.Add(i);
            }

            CheckAndShuffle(tableArray12);

            return tableArray12;
        }

        /// <summary>
        /// Если в массиве нет двух соседних одинаковых элементов, то вернет true.
        /// В противном случае - false.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static bool CheckShuffleResult(List<int> array)
        {
            for (int i = 1; i < array.Count; i++)
            {
                // смотрим текущую и слевастоящую кнопку
                int element = array[i];
                int elementBefore = array[i - 1];

                // если элементы массива равны (т.е. одинаковые цифры рядом стоят) то возвращаем false
                if (element == elementBefore)
                {
                    return false;
                }
            }

            return true;
        }

        // Метод, благодаря которому цифры одинаковые не будут стоять рядом друг с другом
        public static void CheckAndShuffle(List<int> tableArray)
        {
            while (CheckShuffleResult(tableArray) == false)
            {
                Shuffle(tableArray);
            }
        }
        /// <summary>
        /// Скрыть содержимое кнопки через 1 секунду
        /// </summary>
        /// <param name="buttonNumber1">номер кнопки 1</param>
        /// <param name="buttonNumber2">номер кнопки 2</param>
        public async void CloseButtonsAfterOneSecond(int buttonNumber1, int buttonNumber2)
        {
            await Task.Delay(1000);
            CloseButton(buttonNumber1);
            CloseButton(buttonNumber2);

            foreach (Button button in _temporaryGray)
            {
                SetColorQuestion(button);
            }

            _temporaryGray = new List<Button>();
        }

        /// <summary>
        /// Закрыть содержимое кнопки, чтобы его было не видно
        /// </summary>
        /// <param name="buttonNumber">номер кнопки которую закрываем</param>
        public void CloseButton(int buttonNumber)
        {
            SetColorQuestion(buttonNumber);

            // удаляем только что закрытую кнопку из списка открытых кнопок
            _openedButtons.Remove(buttonNumber);
        }

        /// <summary>
        /// Открыть содержимое кнопки, чтобы его было видно
        /// </summary>
        /// <param name="buttonNumber">номер кнопки, которую открываем</param>
        public void OpenButton(int buttonNumber)
        {
            // число, которое загадано
            int imageNumber = _randomNumbersOfImages12[buttonNumber - 1];

            SetColorImage(buttonNumber, imageNumber);

            // добавляем в массив текущую открытую кнопку
            _openedButtons.Add(buttonNumber);
            _lastButtonContains = imageNumber;
            _lastButtonNumber = buttonNumber;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string buttonName = ((Button)sender).Name;
            string buttonNumberStr = buttonName.Replace("button", "");
            int buttonNumber = int.Parse(buttonNumberStr);

            if (_startTime == null)
            {
                _startTime = DateTime.Now;
            }

            if (_openedButtons.Contains(buttonNumber))
            {
                return;
            }

            int buttonContains = _randomNumbersOfImages12[buttonNumber - 1];

            // если было нечетное
            if (_openedButtons.Count % 2 == 1)
            {
                // поле, отвечающее за кол-во шагов,
                labelStep.Text = (int.Parse(labelStep.Text) + 1).ToString();

                // если нечетное одинаковое число: юзер нашел пару
                if (_lastButtonContains == buttonContains)
                {
                    _permanentGray.Add(_lastButtonNumber);
                    _permanentGray.Add(buttonNumber);

                    SetGrayImage(_lastButtonNumber, _randomNumbersOfImages12[_lastButtonNumber - 1]);
                    OpenButton(buttonNumber);
                    SetGrayImage(buttonNumber, _randomNumbersOfImages12[buttonNumber - 1]);

                    SetMiniColorImage(_randomNumbersOfImages12[buttonNumber - 1]);

                    if (_permanentGray.Count == _buttons.Count && _startTime != null)
                    {
                        // открыты все кнопки, таймер останавливается
                        DateTime startTime = (DateTime)_startTime;
                        TimeSpan fromGameStart = DateTime.Now - startTime;
                        _startTime = null;

                        MessageBox.Show("Поздравляем! Вы закончили игру за:\r\n" +
                                        labelStep.Text + " шагов, "
                                        + (int)fromGameStart.TotalMinutes +
                                        " мин. и за " + fromGameStart.Seconds + " сек.");
                    }
                }
                else // если нечетное разное число: юзер ошибся
                {
                    for (int i = 0; i < _buttons.Count; i++)
                    {
                        int currentButtonNumber = i + 1;

                        if (currentButtonNumber != _lastButtonNumber && currentButtonNumber != buttonNumber && !_permanentGray.Contains(currentButtonNumber))
                        {
                            _temporaryGray.Add(_buttons[i]);
                            SetGrayQuestion(currentButtonNumber);
                        }
                    }

                    CloseButtonsAfterOneSecond(_lastButtonNumber, buttonNumber);
                    OpenButton(buttonNumber);
                }
            }
            else // если четное
            {
                OpenButton(buttonNumber);
            }
        }

        /// <summary>
        /// Обращаемся к кнопке, делаем -1 потому что нумерация ключей в массивах
        /// начинается с нуля, а нумерация кнопок с единицы. Далее выставляем фоновую
        /// картинку: черно-белый вопросительный знак (берется из "ресурсов")
        /// </summary>
        /// <param name="buttonNumber"></param>
        private void SetGrayQuestion(int buttonNumber)
        {
            _buttons[buttonNumber - 1].BackgroundImage = Resources.question_gray;
            _buttons[buttonNumber - 1].Enabled = false;
        }

        private void SetColorQuestion(int buttonNumber)
        {
            _buttons[buttonNumber - 1].BackgroundImage = Resources.question_color;
            _buttons[buttonNumber - 1].Enabled = true;
        }

        private void SetColorQuestion(Button button)
        {
            button.BackgroundImage = Resources.question_color;
            button.Enabled = true;
        }

        private void SetColorImage(int buttonNumber, int imageNumber)
        {
            // из массива картинок берем картинку по ключу в виде загадонного числа - 1
            _buttons[buttonNumber - 1].BackgroundImage = _images[imageNumber - 1];
            _buttons[buttonNumber - 1].Enabled = true;
        }

        private void SetGrayImage(int buttonNumber, int imageNumber)
        {
            // из массива картинок берем картинку по ключу в виде загадонного числа - 1
            _buttons[buttonNumber - 1].BackgroundImage = _imagesGray[imageNumber - 1];
            _buttons[buttonNumber - 1].Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Start();

            foreach (Button button in _buttons)
            {
                SetColorQuestion(button);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_startTime != null)
            {
                DateTime startTime = (DateTime)_startTime;
                TimeSpan fromGameStart = DateTime.Now - startTime;

                labelTimer.Text = (int)fromGameStart.TotalMinutes + " мин. и " + fromGameStart.Seconds + " сек.";
            }
        }
    }
}
