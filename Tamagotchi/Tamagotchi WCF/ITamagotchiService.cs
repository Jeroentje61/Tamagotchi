using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Tamagotchi_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITamagotchiService
    {

        [OperationContract]
        int[] GetStatusses();

        [OperationContract]
        string PerformAction(Actions.IAction action);
        
    }


    [DataContract]
    public class TamagotchiStats
    {
        private int _hunger = 0;
        private int _sleep = 0;
        private int _boredom = 0;
        private int _health = 0;

        [DataMember]
        public int Hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                if (value <= 0) _hunger = 0;
                else if (value >= 100) _hunger = 100;
                else _hunger = value;
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
                if (value <= 0) _sleep = 0;
                else if (value >= 100) _sleep = 100;
                else _sleep = value;
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
                if (value <= 0) _boredom = 0;
                else if (value >= 100) _boredom = 100;
                else _boredom = value;
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
                if (value <= 0) _health = 0;
                else if (value >= 100) _health = 100;
                else _health = value;
            }
        }
    }
}
