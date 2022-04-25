using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadAmmo
{
    class Ammo
    {
        public const int AMMO_SIZE = 5;
        public int BulletsLoaded { get; set; }
        private int bullets = 0;
        //private int bulletsLoaded = 0;
        public bool IsEmpty() { return BulletsLoaded == 0; }
        public int BulletsAmount
        {
            get { return bullets; }

            set
            {
                if (value > 0)
                    bullets = value;
                //ReloadAmmo();
            }
        }
        /*public int BulletsLoaded
        {
            get { return bulletsLoaded; }
            set { bulletsLoaded = value; }
        }*/
         
        
        
        public void ReloadAmmo()
        {
            if (bullets >= AMMO_SIZE)
            {
                BulletsLoaded = AMMO_SIZE;
                bullets -= BulletsLoaded;
            }

            else return;       
        }
        //當槍隻有bulletsLoaded時，回傳true並遞減bulletsLoaded欄位 
        public bool Shoot()
        {
            if (BulletsLoaded == 0) return false;
            BulletsLoaded--;
            return true;
        }
    }
}
