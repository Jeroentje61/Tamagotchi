using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Tamagotchi_WCF
{
    
    [ServiceContract]
    public interface ITamagotchiService
    {
        [OperationContract]
        List<Tamagotchi> GetTamagotchis();

        [OperationContract]
        Tamagotchi ChooseTamagotchi(string name);

        [OperationContract]
        List<Tamagotchi> GetLivingTamagotchis();

        [OperationContract]
        void DoSpelregels(List<Tamagotchi> tmgs);

        [OperationContract]
        string PerformAction(string action, Tamagotchi tmg);
        
        [OperationContract]
        Tamagotchi CreateTamagotchi(string name);


    }


    [DataContract]
    public class TamagotchiStats
    {
        private int _hunger = 0;
        private int _sleep = 0;
        private int _boredom = 0;
        private int _health = 0;
        private string _name = "";
        private bool _alive = true;

        public TamagotchiStats()
        {

        }

        public TamagotchiStats(Tamagotchi tmg)
        {
            this._name = tmg.Naam;
            this._boredom = tmg.Boredom;
            this._health = tmg.Health;
            this._hunger = tmg.Hunger;
            this._sleep = tmg.Sleep;
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public int Hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                _hunger = value;
            }
        }

        [DataMember]
        public int Sleep
        {
            get
            {
                return _sleep;
            }
            set
            {
                _sleep = value;
            }
        }
        
        [DataMember]
        public int Boredom
        {
            get
            {
                return _boredom;
            }
            set
            {
                _boredom = value;
            }
        }

        [DataMember]
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        [DataMember]
        public bool Alive
        {
            get
            {
                return _alive;
            }
            set
            {
                if (_alive)
                {
                    _alive = value;
                }
            }
        }
    }
}
