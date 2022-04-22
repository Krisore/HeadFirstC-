﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MathGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            Random random = new Random();
            List<string> animalEmoji = new List<string>()
            {
                "🐶", "🐶",
                "🐱", "🐱",
                "🦁", "🦁",
                "🦊", "🦊",
                "🦝", "🦝",
                "🐻", "🐻",
                "🐮", "🐮",
                "🐷", "🐷",
            };
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }

        }
    }
}
