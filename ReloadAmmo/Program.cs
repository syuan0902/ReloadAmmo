using System;

namespace ReloadAmmo
{
    class Program
    {

        static void Main(string[] args)
        {

            int bulletAmount = ReadInt(20, "起始子彈數量");
            int ammoSize = ReadInt(5, "彈匣容量");

            Console.Write($"是否在遊戲開始時自動填充彈匣 [{true}]: ");
            bool.TryParse(Console.ReadLine(), out bool loaded);

            static int ReadInt(int lastUsedValue, string prompt)
            {
                Console.Write(prompt + " [" + lastUsedValue + "]: ");
                string m_customInput = Console.ReadLine();
                if (int.TryParse(m_customInput, out int value))
                {
                    Console.WriteLine("    使用輸入數值" + value);
                    return value;
                }

                else
                {
                    Console.WriteLine("    使用預設值" + lastUsedValue);
                    return lastUsedValue;
                }
            }


            Ammo gunAmmo = new Ammo(bulletAmount, ammoSize, loaded);
            while (true)
            {
                Console.WriteLine($"\n擁有 {gunAmmo.BulletsAmount}發子彈, 彈匣內有 {gunAmmo.BulletsLoaded} / {ammoSize}");
                if (gunAmmo.IsEmpty()) Console.WriteLine("警告: 彈匣已經空了!!");
                Console.WriteLine($"\n按空白鍵射擊, 按o取得彈匣(得到{ammoSize}發子彈), 按p填充彈匣(消耗{ammoSize}發子彈), 按u離開遊戲");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"\n射擊!!{gunAmmo.Shoot()}");
                else if (key == 'o') gunAmmo.BulletsAmount += gunAmmo.AmmoSize; 
                else if (key == 'p') gunAmmo.ReloadAmmo();
                else if (key == 'u') return;
            }
            
        }
    }
}
