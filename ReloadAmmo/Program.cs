using System;

namespace ReloadAmmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ammo gunAmmo = new Ammo();
            while (true)
            {
                Console.WriteLine($"\n擁有 {gunAmmo.BulletsAmount}發子彈, 彈匣內有 {gunAmmo.BulletsLoaded} / 5發子彈");
                if (gunAmmo.IsEmpty()) Console.WriteLine("警告: 彈匣已經空了!!");
                Console.WriteLine("\n按空白鍵射擊, 按o取得5發子彈, 按p消耗5發子彈補滿彈匣, 按u離開遊戲");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"\n射擊!!{gunAmmo.Shoot()}");
                else if (key == 'o') gunAmmo.BulletsAmount += Ammo.AMMO_SIZE; 
                else if (key == 'p') gunAmmo.ReloadAmmo();
                else if (key == 'u') return;
            }
            
        }
    }
}
