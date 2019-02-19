using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace ParserFlats
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        string path = @"C:\курсовая\parser\данные.xlsx";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        string cian_url_perm = "https://" +"perm.cian.ru/cat.php?deal_type=sale&" +
            "engine_version=2&house_material%5B0%5D=1&house_material%5B1%5D=2&" +
            "house_material%5B2%5D=3&max_house_year=2050&maxfloor=1000&maxfloorn=1000&" +
            "maxtarea=1000&min_house_year=1901&minfloor=0&minfloorn=0&mintarea=0&" +
            "offer_type=flat&quality=1&region=4927&room1=1&room2=1&room3=1&room4=1&room5=1";

        string cian_url_ekat = "https://" + "ekb.cian.ru/cat.php?deal_type=sale&" +
            "engine_version=2&house_material%5B0%5D=1&house_material%5B1%5D=2&" +
            "house_material%5B2%5D=3&max_house_year=2050&maxfloor=1000&maxfloorn=1000&" +
            "maxtarea=1000&min_house_year=1901&minfloor=0&minfloorn=0&mintarea=0&" +
            "offer_type=flat&quality=1&region=4743&room1=1&room2=1&room3=1&room4=1&room5=1";

        string cian_url_nn = "https://" + "nn.cian.ru/cat.php?deal_type=sale&" +
                "engine_version=2&house_material%5B0%5D=1&house_material%5B1%5D=2&" +
                "house_material%5B2%5D=3&max_house_year=2050&maxfloor=1000&maxfloorn=1000&" +
                "maxtarea=37&min_house_year=1901&minfloor=0&minfloorn=0&mintarea=0&" +
                "offer_type=flat&region=4885&room1=1";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "")
            {
                MessageBox.Show("Выберите страницы");
                return;
            }

            if (Browser == null)
            {
                string cian_url = "";
                string cb_value = comboBox1.Text.ToString();
                string url_page = cb_value.Substring(0, cb_value.Length - 3);

                if (radioButton1_perm.Checked)
                    cian_url = cian_url_perm + "&p=" + url_page;

                if (radioButton2_ekat.Checked)
                    cian_url = cian_url_ekat + "&p=" + url_page;

                if (radioButton3_nn.Checked)
                    cian_url = cian_url_nn + "&p=" + url_page;

                Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
                Browser.Manage().Window.Maximize();
                Browser.Navigate().GoToUrl(cian_url);
                comboBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Браузер уже открыт");
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "")
            {
                MessageBox.Show("Выберите страницы");
                return;
            }

            if (Browser == null)
            {
                MessageBox.Show("Откройте браузер");
                return;
            }

            //Browser.Quit();
            //.c6e8ba5398-title--3WDDX
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];
            ws.Cells[1, 1].Value2 = "х1 (общ пл)";
            ws.Cells[1, 2].Value2 = "х2 (комнат)";
            ws.Cells[1, 3].Value2 = "х3 (этаж)";
            ws.Cells[1, 4].Value2 = "х4 (кол этажей)";
            ws.Cells[1, 5].Value2 = "х5 (широта)";
            ws.Cells[1, 6].Value2 = "х6 (долгота)";
            ws.Cells[1, 7].Value2 = "х7 (год постройки дома)";
            ws.Cells[1, 8].Value2 = "х8 (тип стен)";
            ws.Cells[1, 9].Value2 = "х9 (ставка реф)";
            ws.Cells[1, 10].Value2 = "х10 (ср зп)";
            ws.Cells[1, 11].Value2 = "х11 (ВВП)";
            ws.Cells[1, 12].Value2 = "х12 (РТС)";
            ws.Cells[1, 13].Value2 = "х13 (курс доллара)";
            ws.Cells[1, 14].Value2 = "х14 (цена нефти)";
            ws.Cells[1, 15].Value2 = "х15 (ввод жилья)";
            ws.Cells[1, 16].Value2 = "х16 (выд кредиты)";
            ws.Cells[1, 17].Value2 = "у (цена)";

            //вспомогательные данные
            ws.Cells[1, 20].Value2 = "ссылка";
            ws.Cells[1, 21].Value2 = "адрес";

            //textBox1.Clear();
            textBox1.AppendText("\r\n");

            int i_exc = 3;
            
            string cb_value = comboBox1.Text.ToString();
            string url_page = cb_value.Substring(0, cb_value.Length - 3);

            int p_first_num = Convert.ToInt32(url_page),
                p_last_num = p_first_num + 9;
                                                           
            for (int page_number = p_first_num; page_number <= p_last_num; page_number++)
            {

                //изменение страницы
                //если не первая страница (уже открыта)
                if (page_number !=p_first_num)
                {
                    string next_p_url = Browser.Url;

                    if (page_number - 1 < 10)
                        next_p_url = next_p_url.Substring(0, next_p_url.Length - 1);
                    else
                        next_p_url = next_p_url.Substring(0, next_p_url.Length - 2);

                    next_p_url = next_p_url + page_number;
                    Browser.Navigate().GoToUrl(next_p_url);
                }
                

                //список объявлений
                List<IWebElement> adsList;
                adsList = Browser.FindElements(By.CssSelector(".c6e8ba5398-header--1_m0_")).ToList();

                                //adsList.Count
                                //первые 3 - рекламы - пропускаем
                for (int i = 3; i < adsList.Count; i++)
                {
                    string current_url = adsList[i].GetAttribute("href").ToString();
                    string str = "window.open('" + current_url + "','_blank');";
                    ((IJavaScriptExecutor)Browser).ExecuteScript(str);
                    Browser.SwitchTo().Window(Browser.WindowHandles[1].ToString());

                    //задержка 5 секунд и проверка рекламного банера
                    Thread.Sleep(5000);

                    try
                    {
                        IWebElement add_close_button;
                        add_close_button = Browser.FindElement(By.ClassName("a10a3f92e9--close--LxKZn"));
                        add_close_button.Click();
                    }
                    catch
                    {

                    }
                    //сбор инфы о квартире

                    //год постройки
                    List<IWebElement> year_of_building_List =
                        Browser.FindElements(By.CssSelector(".a10a3f92e9--value--38caj")).ToList();

                    //комнат, этаж, этажей в доме, тип стен
                    List<IWebElement> general_inf_List_values =
                        Browser.FindElements(By.CssSelector(".a10a3f92e9--value--3Ftu5")).ToList();
                    List<IWebElement> general_inf_List_param_names =
                        Browser.FindElements(By.CssSelector(".a10a3f92e9--name--3bt8k")).ToList();

                    //общ площадь
                    List<IWebElement> areas_List =
                        Browser.FindElements(By.CssSelector(".a10a3f92e9--info-text--2uhvD")).ToList();


                    //в excel
                    if (general_inf_List_values.Count >= 6 && year_of_building_List.Count >= 1)
                    {
                        int j = 0;
                        //собираем:

                        //цена
                        IWebElement price;
                        price = Browser.FindElement(By.ClassName("a10a3f92e9--price_value--1iPpd"));
                        string price_trimmed = price.Text.ToString();
                        price_trimmed = price_trimmed.Substring(0, price_trimmed.Length - 2);
                        ws.Cells[i_exc - 1, 17].Value2 = price_trimmed;

                        //год постройки дома
                        ws.Cells[i_exc - 1, 7].Value2 = year_of_building_List[0].Text.ToString();

                        //комнат
                        while (general_inf_List_param_names[j].Text.ToString() != "Количество комнат")
                        { j++; }
                        ws.Cells[i_exc - 1, 2].Value2 = general_inf_List_values[j].Text.ToString();

                        //этаж
                        while (general_inf_List_param_names[j].Text.ToString() != "Этаж")
                        { j++; }
                        ws.Cells[i_exc - 1, 3].Value2 = general_inf_List_values[j].Text.ToString();

                        //этажей в доме
                        while (general_inf_List_param_names[j].Text.ToString() != "Этажей в доме")
                        { j++; }
                        ws.Cells[i_exc - 1, 4].Value2 = general_inf_List_values[j].Text.ToString();

                        //этажей в доме
                        while (general_inf_List_param_names[j].Text.ToString() != "Тип дома")
                        { j++; }
                        try
                        {
                            ws.Cells[i_exc - 1, 8].Value2 = general_inf_List_values[j].Text.ToString();
                        }
                        catch { }
                        //СОБИРАЕМ ОСТАЛЬНЫЕ ЭЛЕМЕНТЫ

                        //общ площадь
                        string area = areas_List[0].Text.ToString();
                        area = area.Substring(0, area.Length - 3);
                        ws.Cells[i_exc - 1, 1] = area;


                        //ссылка
                        ws.Cells[i_exc - 1, 20].Value2 = current_url;

                        //адрес дома
                        IWebElement adress;
                        adress = Browser.FindElement(By.ClassName("a10a3f92e9--address--140Ec"));
                        string adress_trimmed;
                        adress_trimmed = adress.Text.ToString();
                        adress_trimmed = adress_trimmed.Substring(0, adress_trimmed.Length - 8);
                        ws.Cells[i_exc - 1, 21] = adress_trimmed;

                        i_exc++;
                    }

                    //добавление в текстовый элемент
                    textBox1.AppendText(current_url + " " + i + " / " + page_number + "стр." + "\r\n");


                    //закрытие вкладки с текущим объявлением
                    Browser.Close();
                    Browser.SwitchTo().Window(Browser.WindowHandles[0].ToString());
                    //string str2 = "window.location.href='" + url2 + "';";
                }



            }

            string new_path = @"C:\курсовая\parser\данные " +
                DateTime.Now.ToString().Replace('/', '-').Replace(':', '-') + ".xlsx";

            //wb.Save();
            wb.SaveAs(new_path);
            wb.Close();

            Browser.Quit();
            Browser = null;
            comboBox1.Enabled = true;
        }
        
    }
}
