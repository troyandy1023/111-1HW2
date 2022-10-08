using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Mindex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int[] o = new int[50] {1,2,3,4,6,8,10,11,12,14,16,19
            ,22,23,24,27,29,33,34,35,37,38,39,43,45,51,52,54,55
            ,61,66,71,72,78,77,80,81,83,88,91,96,97,98,100,101,102,103,104,105,106};
            int[] s = new int[11] {17,18,53,63,64,65,73,76,84,85,86};
            char[,] ia_Map = new char[11, 11];


            /*for (int a = 0; a < 10; a++)
            {
                int b = n[a] / 10;
                int s = n[a] % 10;
                ia_Map[b, s] = '1';
            }*/

            for (int i_Row = 0; i_Row < 11; i_Row++)
            {
                for (int a = 0; a < 50; a++)
                {
                    int b = o[a] / 10;
                    int p = o[a] % 10;
                    ia_Map[b, p] = '1';
                }
                for (int y = 0; y < 11; y++)
                {
                    int q = s[y] / 10;
                    int w = s[y] % 10;
                    ia_Map[q, w] = '2';
                }
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {

                    ia_Map[i_Row, i_Col] = '0';
                }
            }
            for (int i_Ct = 0; i_Ct < 10; i_Ct++)
            {
                int i_Row = ia_Mindex[i_Ct] / 10;
                int i_Col = ia_Mindex[i_Ct] % 10;
                ia_Map[i_Row, i_Col] = '*';
            }

            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    if (ia_Map[i_Row, i_Col] == ' ')
                    {
                        Response.Write("&nbsp");
                    }
                    else
                    {
                        Response.Write(ia_Map[i_Row, i_Col]+" "+"|");
                    }
                }
                Response.Write("<br />");

            }
        }
    }
}