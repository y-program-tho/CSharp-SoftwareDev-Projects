namespace RadioApp
{
    public class Radio
    {
        private int _Channel = 1;
        private bool _On;

        public bool On 
        {
            get { return _On; }
            set { if (_On != false) _On = true; } 
        }

        public int Channel
        {
            get { return _Channel; }
            set { if (_On == true & value >= 1 && value <= 4) _Channel = value; }
        }


        public string Play()
        {
            if (On == true & Channel >= 1 && Channel <= 4)
            {
                return $"Playing channel {Channel}";
            }
            else return $"Radio is off";

        }



        public string TurnOn()
        {
            _On = true;
            if (On == true)
            {
                return $"Radio is on";
            }
            else if (On == true & Channel >= 1 && Channel <= 4)
            {
                return $"Playing channel {Channel}";
            }
            else return $"Radio is off";
        }


        public string TurnOff()
        {
            _On = false;
            if (On == false)
            {
                return $"Rdaio is off";
            }
            else return $"Radio is on";
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}