using static System.Console;

namespace HW_6_polymorphizm
{
    internal class Program
    {

        public abstract class Device
        {
            protected string _name;
            //bool _isElectrical;
            //double _voltage;
            //double _capacityKWt;
            double _weight;
            string _dimension;
            bool _isProfessional;
            bool _isDomestic;
            public Device(string name, double weight, string dimension, bool isProfessional, bool isDomestic)
            {
                _name = name;
                _weight = weight;
                _dimension = dimension;
                _isProfessional = isProfessional;
                _isDomestic = isDomestic;
            }
            public abstract string Sound();
            public abstract string ShowName();
            public abstract string Description();
            public override string ToString()
            {

                return $"\nName:{_name},\tWeight{_weight},\tDimension:{_dimension}," +
                    $"\tProfessional:{_isProfessional},\tDomestic:{_isDomestic}\n";
            }
        }
        class Kettle : Device
        {
            double _volumeWater;
            string _material;
            bool _isElectrical;
            public Kettle(string name, double weight, string dimension, bool isProfessional, bool isDomestic
                , double volume, string material = "Metal", bool isElectrical = true)
                : base(name, weight, dimension, isProfessional, isDomestic)
            {
                _volumeWater = volume;
                _material = material;
                _isElectrical = isElectrical;
            }
            public string Name
            {
                get { return _name; }
            }
            public override string Description()
            {
                return "device for boiling water\n";
            }
            public override string ShowName()
            {
                return $"{this.GetType().Name}\t, {this._name}\n";
            }
            public override string Sound()
            {
                return "Sh-sh-sh-sh-sh!";
            }
            public override string ToString()
            {
                return base.ToString() + $"\nVolume litres:{_volumeWater},\tMaterial:{_material},\tElectrical:{_isElectrical}\n";
            }

            class Microwave : Device
            {
                double _spaceVolume;
                double _capacity;
                public Microwave(string name, double weight, string dimension, bool isProfessional, bool isDomestic, double spaceVolume, double capacity)
                    : base(name, weight, dimension, isProfessional, isDomestic)
                {
                    _spaceVolume = spaceVolume;
                    _capacity = capacity;
                }
                public string Name
                {
                    get { return _name; }
                }
                public override string Description()
                {
                    return $"Make the things warmer by microwave\n";
                }
                public override string ShowName()
                {
                    return $"{this.GetType().Name}\t, {this._name}\n"; ;
                }
                public override string Sound()
                {
                    return "U-u-u-tsh-tsh!\n";
                }
                public override string ToString()
                {
                    return base.ToString() + $"Camera volume is:{_spaceVolume}litres,\tCapacity:{_capacity}kW\n";
                }
            }
            static void Main(string[] args)
            {
                //Kettle kettle = new Kettle("boiler", 5.5, "18x18x30cm", false, true, 2.3);
                ////Kettle kettle1 = new Kettle()
                //Write(kettle.ShowName());
                //WriteLine(kettle.Sound());
                //WriteLine(kettle.Description());
                //Write(kettle); 
                Microwave microwv = new Microwave("Samsung MW", 4.5, "50x40x30cm", false, true, 15, 1.5);
                Write(microwv);
                Write(microwv.Description());
                Write(microwv.ShowName()); 
                Write(microwv.Sound());


            }
        }
    }
}
