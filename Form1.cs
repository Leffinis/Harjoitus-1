using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Harjoitus_1
{
    public partial class Form1 : Form
    {
        private readonly List<FeedItem> _feedItems = new();
        private int _currentIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFeed();
            DisplayCurrentItem();
            UpdateNavigationState();
        }

        private void InitializeFeed()
        {
            _feedItems.Clear();

            _feedItems.AddRange(new[]
            {
                new FeedItem
                {
                    Type = FeedItemType.Lesson,
                    Subject = "История",
                    Title = "Кратко о Великой французской революции",
                    Content = "В 1789 году во Франции началась революция, которая изменила представление о власти. " +
                              "Людовик XVI был вынужден созвать Генеральные штаты, после чего третье сословие " +
                              "объявило себя Национальным собранием. Итогом революции стала ликвидация монархии " +
                              "и утверждение идей свободы, равенства и братства."
                },
                new FeedItem
                {
                    Type = FeedItemType.Lesson,
                    Subject = "Математика",
                    Title = "Теорема Пифагора в действии",
                    Content = "Для прямоугольного треугольника сумма квадратов катетов равна квадрату гипотенузы: " +
                              "a² + b² = c². Это позволяет находить длину стороны, если известны две другие. " +
                              "Например, при катетах 3 и 4 гипотенуза равна 5."
                },
                new FeedItem
                {
                    Type = FeedItemType.Lesson,
                    Subject = "История",
                    Title = "Как складывалась торговля на Великом шёлковом пути",
                    Content = "Великому шёлковому пути более двух тысяч лет. Это сеть караванных путей, " +
                              "соединявших Китай с Европой. По нему перевозили шёлк, специи, стекло, знания и " +
                              "культурные традиции, благодаря чему происходил обмен технологиями и идеями."
                },
                new FeedItem
                {
                    Type = FeedItemType.Quiz,
                    Title = "Квиз по изученному материалу",
                    Quiz = new QuizData
                    {
                        Question = "В каком году началась Великая французская революция?",
                        Options = new[]
                        {
                            "1765",
                            "1789",
                            "1812",
                            "1917"
                        },
                        CorrectOptionIndex = 1,
                        Explanation = "Революция стартовала в 1789 году, когда было созвано Национальное собрание."
                    }
                },
                new FeedItem
                {
                    Type = FeedItemType.Lesson,
                    Subject = "Математика",
                    Title = "Как складывать и вычитать дроби",
                    Content = "Для сложения дробей необходимо привести их к общему знаменателю. " +
                              "После этого складываются числители, а знаменатель остаётся прежним. " +
                              "При вычитании выполняются те же шаги, но числители вычитаются."
                },
                new FeedItem
                {
                    Type = FeedItemType.Lesson,
                    Subject = "История",
                    Title = "О чём напоминала холодная война",
                    Content = "Холодная война — это противостояние между США и СССР, длившееся с конца 1940-х до " +
                              "начала 1990-х годов. Стороны боролись за влияние в мире через экономику, науку и " +
                              "культуру, но избегали прямого военного столкновения."
                },
                new FeedItem
                {
                    Type = FeedItemType.Lesson,
                    Subject = "Математика",
                    Title = "Функции и их графики",
                    Content = "Функция связывает каждое значение x с единственным значением y. " +
                              "Графики помогают увидеть, как меняется функция, и находить ключевые точки: " +
                              "экстремумы, пересечения с осями и области возрастания."
                },
                new FeedItem
                {
                    Type = FeedItemType.Quiz,
                    Title = "Квиз: проверь себя ещё раз",
                    Quiz = new QuizData
                    {
                        Question = "Сколько будет гипотенуза прямоугольного треугольника с катетами 5 и 12?",
                        Options = new[]
                        {
                            "11",
                            "12",
                            "13",
                            "17"
                        },
                        CorrectOptionIndex = 2,
                        Explanation = "По теореме Пифагора: 5² + 12² = 25 + 144 = 169, корень из 169 — это 13."
                    }
                }
            });
        }

        private void DisplayCurrentItem()
        {
            if (_feedItems.Count == 0)
            {
                return;
            }

            var item = _feedItems[_currentIndex];

            counterLabel.Text = $"{_currentIndex + 1}/{_feedItems.Count}";
            subjectLabel.Text = item.Type == FeedItemType.Lesson ? item.Subject : "Квиз";
            subjectLabel.ForeColor = item.Type switch
            {
                FeedItemType.Quiz => Color.FromArgb(0, 120, 215),
                FeedItemType.Lesson when string.Equals(item.Subject, "История", StringComparison.OrdinalIgnoreCase) => Color.FromArgb(192, 81, 0),
                FeedItemType.Lesson when string.Equals(item.Subject, "Математика", StringComparison.OrdinalIgnoreCase) => Color.FromArgb(76, 17, 136),
                _ => Color.Black
            };
            titleLabel.Text = item.Title;
            contentBox.Text = item.Type == FeedItemType.Quiz && item.Quiz != null
                ? item.Quiz.Question
                : item.Content;
            contentBox.Select(0, 0);
            contentBox.ScrollToCaret();

            if (item.Type == FeedItemType.Quiz && item.Quiz != null)
            {
                RenderQuizOptions(item.Quiz);
            }
            else
            {
                quizOptionsPanel.Controls.Clear();
                quizOptionsPanel.Visible = false;
                quizResultLabel.Visible = false;
            }
        }

        private void RenderQuizOptions(QuizData quiz)
        {
            quizOptionsPanel.SuspendLayout();
            quizOptionsPanel.Controls.Clear();

            for (int i = 0; i < quiz.Options.Length; i++)
            {
                var optionButton = new Button
                {
                    AutoSize = false,
                    Height = 44,
                    Margin = new Padding(0, i == 0 ? 0 : 10, 0, 0),
                    Padding = new Padding(16, 8, 12, 8),
                    Tag = i,
                    Text = $"{(char)('A' + i)}. {quiz.Options[i]}",
                    TextAlign = ContentAlignment.MiddleLeft,
                    UseVisualStyleBackColor = false,
                    BackColor = Color.WhiteSmoke,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Black,
                    Cursor = Cursors.Hand
                };

                optionButton.FlatAppearance.BorderColor = Color.Gainsboro;
                optionButton.FlatAppearance.BorderSize = 1;
                optionButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
                optionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                optionButton.Click += QuizOption_Click;
                quizOptionsPanel.Controls.Add(optionButton);
            }

            quizOptionsPanel.ResumeLayout();
            quizOptionsPanel.Visible = true;
            quizResultLabel.Visible = true;
            quizResultLabel.ForeColor = SystemColors.GrayText;
            quizResultLabel.Text = "Выберите ответ, чтобы проверить себя.";

            AdjustQuizOptionWidths();
        }

        private void QuizOption_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (button.Tag is not int selectedIndex)
            {
                return;
            }

            var item = _feedItems[_currentIndex];

            if (item.Type != FeedItemType.Quiz || item.Quiz is null)
            {
                return;
            }

            var quiz = item.Quiz;
            bool isCorrect = selectedIndex == quiz.CorrectOptionIndex;

            quizResultLabel.Visible = true;
            quizResultLabel.ForeColor = isCorrect ? Color.ForestGreen : Color.Firebrick;
            quizResultLabel.Text = isCorrect
                ? "Верно! " + quiz.Explanation
                : "Неверно. " + quiz.Explanation;

            foreach (Button optionButton in quizOptionsPanel.Controls.OfType<Button>())
            {
                optionButton.Enabled = false;

                if (optionButton.Tag is int optionIndex)
                {
                    if (optionIndex == quiz.CorrectOptionIndex)
                    {
                        optionButton.BackColor = Color.FromArgb(210, 255, 210);
                        optionButton.FlatAppearance.BorderColor = Color.ForestGreen;
                    }
                    else if (optionIndex == selectedIndex)
                    {
                        optionButton.BackColor = Color.FromArgb(255, 220, 220);
                        optionButton.FlatAppearance.BorderColor = Color.Firebrick;
                    }
                    else
                    {
                        optionButton.BackColor = Color.WhiteSmoke;
                        optionButton.FlatAppearance.BorderColor = Color.Gainsboro;
                    }
                }
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            MoveToItem(_currentIndex - 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            MoveToItem(_currentIndex + 1);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down || e.KeyCode == Keys.Space)
            {
                MoveToItem(_currentIndex + 1);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                MoveToItem(_currentIndex - 1);
                e.Handled = true;
            }
        }

        private void quizOptionsPanel_SizeChanged(object? sender, EventArgs e)
        {
            AdjustQuizOptionWidths();
        }

        private void MoveToItem(int newIndex)
        {
            if (newIndex < 0 || newIndex >= _feedItems.Count)
            {
                return;
            }

            _currentIndex = newIndex;
            DisplayCurrentItem();
            UpdateNavigationState();
        }

        private void UpdateNavigationState()
        {
            previousButton.Enabled = _currentIndex > 0;
            nextButton.Enabled = _currentIndex < _feedItems.Count - 1;
        }

        private void AdjustQuizOptionWidths()
        {
            if (quizOptionsPanel.Controls.Count == 0)
            {
                return;
            }

            int width = Math.Max(120, quizOptionsPanel.ClientSize.Width - 4);

            foreach (Button optionButton in quizOptionsPanel.Controls.OfType<Button>())
            {
                optionButton.Width = width;
            }
        }

        private enum FeedItemType
        {
            Lesson,
            Quiz
        }

        private sealed class FeedItem
        {
            public FeedItemType Type { get; init; }

            public string Subject { get; init; } = string.Empty;

            public string Title { get; init; } = string.Empty;

            public string Content { get; init; } = string.Empty;

            public QuizData? Quiz { get; init; }
        }

        private sealed class QuizData
        {
            public string Question { get; init; } = string.Empty;

            public string[] Options { get; init; } = Array.Empty<string>();

            public int CorrectOptionIndex { get; init; }

            public string Explanation { get; init; } = string.Empty;
        }
    }
}
