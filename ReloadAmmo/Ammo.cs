using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadAmmo
{
    class Ammo
    {
        public int AmmoSize { get; private set; } = 5;
        public int BulletsLoaded { get; private set; }
        private int bullets = 0;
        //private int bulletsLoaded = 0;
        public bool IsEmpty() { return BulletsLoaded == 0; }
        
        //使用有參數的建構式來初始化屬性
        public Ammo(int bullets, int ammoSize, bool loaded)
        {
            this.bullets = bullets;
            AmmoSize = ammoSize;
            if (loaded) ReloadAmmo();
        }

        public int BulletsAmount
        {
            get { return bullets; }

            set
            {
                if (value > 0)
                    bullets = value;
            }
        }
        /*public int BulletsLoaded
        {
            get { return bulletsLoaded; }
            set { bulletsLoaded = value; }
        }*/
         
        
        
        public void ReloadAmmo()
        {
            if(BulletsLoaded != AmmoSize)
            {
                if (bullets >= AmmoSize)
                {
                    BulletsLoaded = AmmoSize;
                    bullets -= BulletsLoaded;
                }
                else return;
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
