using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Restaurant
{
    public class Globals
    {
        public static int counttax = 0;
        public static int checkprint = 0;
        public static bool checkprintbutton = false;
        public static int checkendday = 0,checkconfirm=0;
        public static int discount = 0;
        public static double pasi = 0;
        public static int pax = 0;
        
        public static int status1 = 0;
        public static int status2 = 0;
        public static int status3 = 0;
        public static int status4 = 0;
        public static int status5 = 0;
        public static int status6 = 0;
        public static int status7 = 0;
        public static int status8 = 0;
        public static int status9 = 0;
        public static int status10 = 0;
        public static int status11 = 0;
        public static int status12 = 0;

        //DateTime localDate = DateTime.Now;
        public static DateTime date = DateTime.Now;
        public static string dateno = date.ToString("yyMMdd");
        public static string datenow = date.ToString("HH:mm:ss");
        public static string datenosec = date.ToString("HH:mm");
        public static string dateonly = date.ToString("dd/MM/yyyy");
        public static string dateshort = date.ToString("dd/MM/yy");

        //MENU ITEMS

        public static double sum = 0;

        //                                  0        1        2        3       4          5          6          7             8
        public static string[] menu1 = { "น้ำยาปลา", "น้ำยาไก่", "น้ำยาใต้", "น้ำพริก", "น้ำยาปู", "แกงเขียวหวาน", "น้ำเงี้ยว", "ขนมจีนแกงป่า", "ขนมจีนซาวน้ำ" };
        public static int[] price1 = { 79 ,79,79,89,119,89,89,79,129};
        public static double[] count1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //                                  0        1        2        3       4          5          6          7             8
        public static string[] menu2 = { "ปีกไก่รมควัน", "ลูกชิ้นปลาบางกอก", "หมูหมักลวกจิ้ม", "ปอเปี๊ยะบางกอก", "หมูนุ่มบางกอก", "คอหมูอบจิ้มแจ่ว", "ยำลูกชิ้น", "ทอดมันกุ้ง", "ปลากะพงลวกจิ้ม" };
        public static int[] price2 = { 129, 79, 119, 89, 119, 119, 99, 119, 119 };
        public static double[] count2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //                                  0        1        2        3       4          5          6          7             8
        public static string[] menu3 = { "คะน้าหมูกรอบ", "ผัดผักรวมมิตร", "หมูกรอบผัดพริกเผา", "น้ำพริกกุ้งสด", "หมูนนุ่มผัดกะปิ", "แกงส้มชะอมไข่", "แกงเลียง", "ต้มยำเห็ด", "ต้มแซ่บกระดูกอ่อน","ข้าวเปล่า","ข้าวเหนียว","ขนมจีนเปล่า" };
        public static int[] price3 = { 129, 119, 119, 119, 119, 139, 149, 139, 139,15,15,15 };
        public static double[] count3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0,0,0};

        //                                  0        1        2        3       4
        public static string[] menu4 = { "ไอศครีมกะทิ", "กล้วยไข่บวชชี", "กล้วยไข่ไอศครีม", "เฉาก๊วย", "ทับทิมกรอบ" };
        public static int[] price4 = { 29, 35, 35, 29, 35};
        public static double[] count4 = { 0, 0, 0, 0, 0};

        public static string[] menu5 = { "น้ำใบเตย", "น้ำตะไคร้", "น้ำเก๊กฮวย", "น้ำกระเจี๊ยบ", "น้ำลำใย", "น้ำมะนาว", "ชามะนาว","ชาเย็น", "กาแฟเย็น", "น้ำแข็ง","น้ำเปล่า" };
        public static int[] price5 = { 29, 29, 29, 29, 29, 79, 49,49, 49, 3,15 };
        public static double[] count5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0 };

        //public static double sumcount = (count1[0] + count1[1] + count1[2] + count1[3] + count1[4] + count1[5] + count1[6] + count1[7] + count1[8]/*+ count2[0] + count2[1] + count2[2] + count2[3] + count2[4] + count2[5] + count2[6] + count2[7] + count2[8]*/);
        //public static double percount = (count1[0]*100)/(count1[0]+ count1[1] + count1[2] + count1[3] + count1[4] + count1[5] + count1[6] + count1[7] + count1[8]);

        public static int a = 1;
    }
}
