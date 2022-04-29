using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmericanAutoMobiles.Model
{
    public enum ColorEnum
    {
        Red,
        Green,
        Blue,
        Yellow,
        Magenta,
        Cyan
    }

    public enum StatusEnum
    {
        Active,
        OnHold,
        InActive
    }

    public class Car
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public virtual string GetStatus()
        {
            return Status.ToString();
        }
        
    }


    public class Dealer1: Car
    {

        public override string GetStatus()
        {
            if (Status == StatusEnum.Active.ToString())
                return "For Sale";
            else
                return Status;
        }
    }

    public class Dealer2 : Car
    {
        public override string GetStatus()
        {
            return Status.ToString();
        }
    }




    public class DbContext
    {

        public List<Dealer1> GetDealer1Cars()
        {
            List<Dealer1> Dealer1Cars = new List<Dealer1>{
                new Dealer1{Price=10000,Model="GM", Mileage=25,Color=ColorEnum.Blue.ToString(), Status=StatusEnum.Active.ToString()},
                new Dealer1{Price=20000,Model="Ford", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer1{Price=15000,Model="Chrysler", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()},
                                new Dealer1{Price=20000,Model="GM", Mileage=25,Color=ColorEnum.Blue.ToString(), Status=StatusEnum.Active.ToString()},
                new Dealer1{Price=21000,Model="Ford", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer1{Price=15000,Model="Chrysler", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()},
                                new Dealer1{Price=30000,Model="GM", Mileage=25,Color=ColorEnum.Blue.ToString(), Status=StatusEnum.Active.ToString()},
                new Dealer1{Price=20000,Model="Ford", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer1{Price=15000,Model="Chrysler", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()}
            };
            return Dealer1Cars;
        }

        public List<Dealer2> GetDealer2Cars()
        {
            List<Dealer2> Dealer2Cars = new List<Dealer2>{
                new Dealer2{Price=10000,Model="GM", Mileage=25,Color=ColorEnum.Blue.ToString(), Status=StatusEnum.Active.ToString()},
                new Dealer2{Price=20000,Model="Ford", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer2{Price=15000,Model="Chrysler", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()},
                new Dealer2{Price=20000,Model="Civic", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer2{Price=15000,Model="Toyota", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()},
                                new Dealer2{Price=10000,Model="GM", Mileage=25,Color=ColorEnum.Blue.ToString(), Status=StatusEnum.Active.ToString()},
                new Dealer2{Price=20000,Model="Ford", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer2{Price=15000,Model="Chrysler", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()},
                new Dealer2{Price=20000,Model="Civic", Mileage=35,Color=ColorEnum.Red.ToString(), Status=StatusEnum.InActive.ToString()},
                new Dealer2{Price=15000,Model="Toyota", Mileage=22,Color=ColorEnum.Green.ToString(), Status=StatusEnum.OnHold.ToString()}
            };
            return Dealer2Cars;
        }
    }
    
}