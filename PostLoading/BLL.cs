using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;


using System.Transactions;

namespace PostLoading
{
    class BLL
    {
        public bool IsDoreExist(string name)
        {
            using (var db = new PostDataSetTableAdapters.DoreTableAdapter())
            {
                return db.IsDoreExist(name) > 0;
            }
        }

        public int AddDore(string name)
        {
            using (var db = new PostDataSetTableAdapters.DoreTableAdapter())
            {
                if (name != "")
                {
                    object obj = db.InsertDore(name);                    
                    return obj.ToInt();
                }
            }
            return -1;
        }

        public PostDataSet.DoreDataTable GetDoreList()
        {
            using (var db = new PostDataSetTableAdapters.DoreTableAdapter())
            {
                return db.GetDoreList();
            }
        }

        public DataView GetDoreDetail(int doreId)
        {
            if (doreId <= 0)
                return null;

            using (var db = new PostDataSetTableAdapters.DoreDetailTableAdapter())
            {
                return new DataView(db.GetDetailByDoreId(doreId));
            }
        }


 

        public void AddDoreDetailFromFiles(List<string> files, int ignoreRows, int doreId, BackgroundWorker worker)
        {
            using (var adapter = new PostDataSetTableAdapters.DoreDetailTableAdapter())
            //using (var trans = new TransactionScope())
            {
                adapter.Connection.Open();
                adapter.Transaction = adapter.Connection.BeginTransaction();             
                

                foreach (var file in files)
                {
                    if (File.Exists(file))
                    {
                        FileStream stream = null;
                        IExcelDataReader excelReader = null;

                        try
                        {
                            stream = File.Open(file.ToString(), FileMode.Open, FileAccess.Read);

                            excelReader = Excel.ExcelReaderFactory.CreateOpenXmlReader(stream);
                            DataSet dataset = excelReader.AsDataSet();

                            if (dataset == null)
                                return;

                            DataTable dt = dataset.Tables[0];


                            if (doreId > 0)
                            {
                                for (int i = ignoreRows + 1; i < dt.Rows.Count; i++)
                                {
                                    if (dt.Rows[i][0] == null || dt.Rows[i][0].ToString() == "")
                                        break;


                                    AddDoreDetail(adapter, doreId,
                                        dt.Rows[i][27].ToString(),
                                        dt.Rows[i][24].ToString(),
                                        dt.Rows[i][22].ToString(),
                                        dt.Rows[i][21].ToString(),
                                        dt.Rows[i][20].ToString(),
                                        dt.Rows[i][19].ToString(),
                                        dt.Rows[i][18].ToString(),
                                        dt.Rows[i][17].ToString(),
                                        dt.Rows[i][16].ToString(),
                                        dt.Rows[i][15].ToString(),
                                        dt.Rows[i][12].ToString(),
                                        dt.Rows[i][9].ToString(),
                                        dt.Rows[i][8].ToString(),
                                        dt.Rows[i][5].ToString(),
                                        dt.Rows[i][3].ToString(),
                                        dt.Rows[i][0].ToString());
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            adapter.Transaction.Rollback();
                            if (ex.Message.Contains("because it is being used by another process"))
                            {
                                throw new Exception("فایل \r\n" + file + "\r\n در حال استفاده است ابتدا آن را بسته و سپس اقدام کنید.");
                            }
                            else
                            {
                                throw ex;
                            }                            
                        }
                        finally
                        {
                            try
                            {
                                if (excelReader != null)
                                    excelReader.Close();

                                stream.Close();
                            }
                            catch
                            {
                            }
                        }
                    }

                    worker.ReportProgress(0);
                }
                adapter.Transaction.Commit();
            }


            
        }

        private int AddDoreDetail(PostDataSetTableAdapters.DoreDetailTableAdapter db, int doreId, string marsoole_id,
            string sender,
            string receiver, string destination, string detail_time, string hagh_maghar,
            string destination_code, string source_code, string d, string vazn,
            string mablagh_ezhar, string haghe_bime, string maliat, string hagh_sahm_p,
            string hagh_sahm_t_gh, string price)
        {
            if (marsoole_id.Trim() == "جمع")
                return -1;

            sender = sender.RemoveArabicKaf().ReplaceWithArabicYa();
            receiver = receiver.RemoveArabicKaf().ReplaceWithArabicYa();
            destination = destination.RemoveArabicKaf().ReplaceWithArabicYa();

            //marsoole_id = Encoding.Unicode.GetString(Encoding.ASCII.GetBytes(marsoole_id));
            //sender = Encoding.Unicode.GetString(Encoding.ASCII.GetBytes(sender));
            //receiver = Encoding.Unicode.GetString(Encoding.ASCII.GetBytes(receiver));
            //destination = Encoding.Unicode.GetString(Encoding.ASCII.GetBytes(destination));
            //detail_time = Encoding.Unicode.GetString(Encoding.ASCII.GetBytes(detail_time));


            return db.InsertDoreDetail(doreId, marsoole_id, sender, receiver,
                destination, detail_time, hagh_maghar.ToLong(), destination_code, source_code, d,
                vazn.ToDouble(), mablagh_ezhar.ToLong(), haghe_bime.ToLong(), maliat.ToLong(),
                hagh_sahm_p.ToLong(), hagh_sahm_t_gh.ToLong(), price.ToLong());

            // return -1;
        }
    }
}
