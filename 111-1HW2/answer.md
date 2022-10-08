# 第2次作業-作業-HW2
>
>學號：109111103
><br />
>姓名：曾昱翔
><br />
>作業撰寫時間：135 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/10/08
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容


開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

先指定10格有炸彈，指定一個10 * 10的陣列(下面打11 * 11 不然的話某些地方跑不出來)，
指定50格為1代表附近有一個炸彈，指定11個為2代表附近有兩個炸彈，用for迴圈讓陣列跑出相應的符號。
```
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
```

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

這次作業適用上次隨堂去改的，因為實在沒辦法像其他同學那樣精通for、二維陣列等等...。
這個程式毫無疑問並不符合老師所要求的做法，但想了很久最後還是決定用最原始的方法，
但即使是最簡單最原始的做法，還是花了2個多小時才終於有辦法讓程式執行，
作業需要的觀念像for的判斷、陣列的轉換我都不具備，只能做出相同結果的東西。 