﻿using System;
using System.Windows.Forms;

namespace HandleControl {
    static class ForTextbox {
        public static void SetPlaceHolder(TextBox textBox, string PlaceHolderText) {
            textBox.Text = PlaceHolderText;
            textBox.GotFocus += delegate (object sender, EventArgs args) {
                if (textBox.Text == PlaceHolderText) {
                    textBox.Text = "";
                }
            };
            textBox.LostFocus += delegate (object sender, EventArgs args) {
                if (textBox.Text.Length == 0) {
                    textBox.Text = PlaceHolderText;
                }
            };
        }
    }
}