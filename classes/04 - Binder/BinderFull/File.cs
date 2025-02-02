﻿namespace P21Classes
{
    class File
    {
        private static int _globalId = 1;

        public int Id { get; }
        public string Text { get; private set; }
        public Category Category { get; set; }
        public string CategoryName => Category.Name;

        public File(string text)
        {
            Text = text;
            Id = _globalId++;
        }

        public override string ToString()
        {
            return $"{Id}:{Text}";
        }
    }
}
