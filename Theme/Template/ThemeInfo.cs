﻿using Oqtane.Themes;

namespace Example.Oqt.Themes.Template
{
    public class ThemeInfo : ITheme
    {
        public Oqtane.Models.Theme Theme => new Oqtane.Models.Theme
        {
            Name = "Example Oqtane Theme - Template",
            Version = "0.0.1"
        };

        public void test()
        {
            var x = new NoTitle();
        }
    }
}