﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private GameSettings _settings;

        public Form1()
        {
            InitializeComponent();
            _settings = new GameSettings();
        }
    }
}