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

        private int bullets = 0;
        private int bulletsLoaded = 0;
        public bool IsEmpty() { return bulletsLoaded == 0; }
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
        public int BulletsLoadedAmount
        {
            get { return bulletsLoaded; }
            set { bulletsLoaded = value; }
        }
         
        
        
        public void ReloadAmmo()
        {
            if (bullets >= AMMO_SIZE)
            {
                bulletsLoaded = AMMO_SIZE;
                bullets -= bulletsLoaded;
            }

            else return;       
        }
        //當槍隻有bulletsLoaded時，回傳true並遞減bulletsLoaded欄位 
        public bool Shoot()
        {
            if (bulletsLoaded == 0) return false;
            bulletsLoaded--;
            return true;
        }
    }
}
