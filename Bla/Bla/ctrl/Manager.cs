using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Bla.Logic;

namespace Bla.ctrl
{
    public static class Manager
    {
        static public int CurrentPatientId { get; set; }
        static public int CurrentChosenDocuId { get; set; }
        static public List<WeeklyDocumentation> WeeklyDocumentations { get; set; } = new List<WeeklyDocumentation>();

        public static TableRow InitCells(int a)
        {
            TableRow row = new TableRow();
            TableCell[] cells = new TableCell[a];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new TableCell();
                cells[i].Attributes.Add("runat", "server");
            }
            row.Cells.AddRange(cells);
            row.Attributes.Add("runat", "server");
            return row;
        }

        public static TableRow InitArray(int a)
        {
            return InitCells(a);
        }
        
        public static TableRow[] InitRows(int b,int a)
        {
            TableRow[] result = new TableRow[b];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = InitCells(a);
            }
            return result;
        }

        public static void NewNewsfeed(NewsFeedEntry feedEntry)
        {
            HttpHelper.SendNewsfeed(feedEntry, "sada");
        }
        public static void GetWeeklyDokumentation(int patientId)
        {
            WeeklyDocumentations = HttpHelper.GetWeeklyDocumentations(patientId, "bla").Result; 
        }
    }
}