using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Transport
    {
        public int capacity { set; get; }
        public int countbox { set; get; }
        public int carrying_capacity { set; get; }
        public string CanYouCarry(Box a)
        {
            if(capacity>a.volume*countbox)
            {
                string message = "может поместиться";
                return message;
            }
            else
            {
                string message = "не может поместиться";
                return message;
            }
        }
        public string CanYouCarrying_Capacity(Box a)
        {
            if(carrying_capacity>a.weight_box*countbox)
            {
                string message = "не превышает допустимого веса";
                return message;
            }
            else
            {
                string message = " превышает допустимого веса";
                return message;
            }
            
        }
            
    }
}
