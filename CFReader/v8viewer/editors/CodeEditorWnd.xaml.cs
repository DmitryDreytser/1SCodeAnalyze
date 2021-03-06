﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using V8Reader.Core;

namespace V8Reader.Editors
{
    /// <summary>
    /// Логика взаимодействия для CodeEditor.xaml
    /// </summary>
    public partial class CodeEditorWnd : Window
    {

        //styles
        
        public CodeEditorWnd()
        {
            InitializeComponent();
            Utils.FormsSettingsManager.Register(this, "CodeEditor");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            codeTextBox.Focus();
        }

    }
}
