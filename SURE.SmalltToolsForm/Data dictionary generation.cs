using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SURE.SmalltToolsForm
{
    public partial class DataDictionaryGeneration : Form
    {
        #region 属性、构造函数

        private static DBGeneral dBGeneral = new DBGeneral();

        private static string strConnction;

        private static ArrayList dataBaseArray;

        private static string savePath = "";

        public DataDictionaryGeneration()
        {
            InitializeComponent();
        }

        #endregion

        #region 私有方法

        public static void Generate(string dataBase)
        {
            string strSql = $" use [{dataBase}] {Properties.Resources.strSql}";
            if (!string.IsNullOrEmpty(strConnction.Trim()))
            {
                using (SqlConnection sqlConnection = new SqlConnection(strConnction))
                {
                    sqlConnection.Open();
                    sqlConnection.InfoMessage += new SqlInfoMessageEventHandler(GenerateHtml);
                    SqlCommand sqlCommand = new SqlCommand(strSql.ToString(), sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        //生成字典
        private static void GenerateHtml(object sender, SqlInfoMessageEventArgs e)
        {
            if (!string.IsNullOrEmpty(savePath))
            {
                Regex regex = new Regex("(?<=已将数据库上下文更改为 ').*?(?='。)", RegexOptions.IgnoreCase);
                string result = regex.Replace(e.Message, "删除").Replace("已将数据库上下文更改为 '删除'。", "");
                File.WriteAllText($"{savePath}\\数据字典.html", result, Encoding.UTF8);
            }
        }

        #endregion

        //选择保存文件夹
        private void butSelectionPath_Click(object sender, EventArgs e)
        {
            if (labLoginMessage.Text.Trim().Equals("Not logged in"))
            {
                MessageBox.Show("未登录", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "选择保存文件路径";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = folderBrowserDialog.SelectedPath;
                labSavePathExhibition.Text = foldPath;
                savePath = foldPath;
                //启用生成按钮
                butGenerate.Enabled = true;
            }
        }

        //加载
        private void DataDictionaryGeneration_Load(object sender, EventArgs e)
        {
            butGenerate.Enabled = false;
            comboxDataBase.Enabled = false;
            butSelectionPath.Enabled = false;
            //赋值上一次的登录信息
            textServerAddress.Text = Properties.Resources.serverAddress;
            textUser.Text = Properties.Resources.userName;
            textPwd.Text = Properties.Resources.passWord;

            labSavePathExhibition.Text = "请选择存储路径...";
        }

        //登录
        private void butLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textServerAddress.Text.Trim())
                && string.IsNullOrEmpty(textUser.Text.Trim())
                && string.IsNullOrEmpty(textPwd.Text.Trim()))
            {
                MessageBox.Show("认真填写登录信息", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            strConnction = $"SERVER = { textServerAddress.Text.Trim() }; DATABASE = MASTER; UID = { textUser.Text.Trim() }; PWD = { textPwd.Text.Trim() }";
            string sqlStr = "SELECT NAME FROM SYSDATABASES ORDER BY NAME";
            string errorMessage = (string)null;
            dataBaseArray = dBGeneral.GetDataByConAndSql(strConnction, sqlStr, out errorMessage);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show($"{errorMessage}", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            comboxDataBase.DataSource = dataBaseArray;
            labLoginMessage.Text = "Already logged in";
            butSelectionPath.Enabled = true;
            comboxDataBase.Enabled = true;
            //记录这次一次的登录信息
        }

        //下拉列表改变
        private void comboxDataBase_TextUpdate(object sender, EventArgs e)
        {
            List<string> dataBaseList = new List<string>();
            foreach (var dataBase in dataBaseArray)
            {
                dataBaseList.Add(dataBase.ToString());
            }
            if (string.IsNullOrEmpty(comboxDataBase.Text.Trim()))
            {
                comboxDataBase.DataSource = dataBaseList;
                return;
            }
            var comDataBase = dataBaseList.Where(i => i.StartsWith(comboxDataBase.Text.Trim())).ToList();
            comboxDataBase.DataSource = comDataBase;
            comboxDataBase.Focus();
        }

        //生成
        private void butGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboxDataBase.Text) && labSavePathExhibition.Text.Equals("请选择存储路径..."))
                {
                    return;
                }
                Generate(comboxDataBase.Text);
                labSavePathExhibition.Text = $"{savePath}\\数据字典.html";
                labSavePathExhibition.Click += new EventHandler(this.OpenFile);
                MessageBox.Show($"生成成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //打开文件
        private void OpenFile(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", $"{savePath}\\数据字典.html");
        }
    }
}
