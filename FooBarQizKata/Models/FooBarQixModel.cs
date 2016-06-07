namespace FooBarQizKata.Model
{
    public abstract class FooBarQixModel
    {
        protected int _number;
        protected char _char;
        protected string _translation;

        public int Number
        {
            get { return _number; }
            protected set { _number = value; }
        }

        public char Char
        {
            get { return _char; }
            protected set { _char = value; }
        }

        public string Translation
        {
            get { return _translation; }
            protected set { _translation = value; }
        }
    }
}
