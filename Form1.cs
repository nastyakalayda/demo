using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}


/*



//при создании кнопки, что бы перейти на другую форму/стр используется этот код
using System;

public MainForm()
{
    InitializeComponent();
}

private void (название кнопки)_Click(object sender, EventArgs e)
{
    (название формы) form = new (название формы)();
    form.Show();
}

/*Этот код выглядит как код C# для приложения Windows Forms. Первый метод, «специальностиBindingNavigatorSaveItem_Click», 
 * представляет собой обработчик событий для нажатия кнопки сохранения на элементе управления навигатора, связанном 
 * с источником данных. В этом методе код выполняет проверку данных и обновляет источник данных с помощью метода «UpdateAll» 
 * в «tableAdapterManager».

Второй метод, «SpecialtyForm_Load», представляет собой обработчик событий для загрузки формы. В этом методе код заполняет
адаптер таблицы данных данными из источника данных.

public (название формы) ()
{
    InitializeComponent();
}

//эти кнопки берутся из элемента BindingNavigator
private void специальностиBindingNavigatorSaveItem_Click(object sender,
EventArgs e)
{
    this.Validate();
    this.специальностиBindingSource.EndEdit();
    this.tableAdapterManager.UpdateAll(this.базаданных);
}
private void SpecialtyForm_Load(object sender, EventArgs e)
{

    this.специальностиTableAdapter.Fill(this.базаданных.таблица);
}

private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs 
e)



 {
 this.Validate();
 this.студентыBindingSource.EndEdit();
 this.tableAdapterManager.UpdateAll(this.базаданных);
 }
 private void StudentsForm_Load(object sender, EventArgs e)
 { 
this.специальностиTableAdapter.Fill(this.базаданных.таблица);
 this.студентыTableAdapter.Fill(this.базаданных.таблица);
 }
 private void (название кнопки)_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MoveFirst();
 }
 private void (название кнопки)_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MovePrevious();
 }
 private void (название кнопки)_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MoveLast();
 }
 private void (название кнопки)_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MoveNext();
 }
 private void (название кнопки)_Click(object sender, EventArgs e)
 {
 студентыBindingSource.AddNew();
 }
 private void (название кнопки)_Click(object sender, EventArgs e)
 {
 студентыBindingSource.RemoveCurrent();
 }
 private void SaveButton_Click(object sender, EventArgs e)
 {
 this.Validate();
 this.студентыBindingSource.EndEdit();
 this.tableAdapterManager.UpdateAll(this.базаданных);
 }
 private void TableButton_Click(object sender, EventArgs e)
 {
 (название формы) form = new (название формы)();
 form.Show();
 }

if (радиокнопка за увеличение.Checked) элементDataGridView.Sort(Col, 
System.ComponentModel.ListSortDirection.Ascending);
 else элементDataGridView.Sort(Col, 
System.ComponentModel.ListSortDirection.Descending)

private void FilterButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.Filter = "ФИО='" + FIOcomboBox.Text + "'";
 }
 private void ShowButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.Filter = "";
 }
 private void SearchButton_Click(object sender, EventArgs e)
 {
 int i = 0;
 int j = 0;
 for (i = 0; i < студентыDataGridView.ColumnCount - 1; i++)
 {
 for (j = 0; j < студентыDataGridView.RowCount - 1; j++)
 {
 студентыDataGridView.Rows[j].Cells[i].Style.BackColor = 
Color.White;
48
 студентыDataGridView.Rows[j].Cells[i].Style.ForeColor = 
Color.Black;
 }
 }
 for (i = 0; i < студентыDataGridView.ColumnCount; i++)
 {
 for (j = 0; j < студентыDataGridView.RowCount; j++)
 {
 var val = студентыDataGridView.Rows[j].Cells[i].Value;
if (val != null)
{
 string vals = val.ToString();
 if (vals.IndexOf(SearchtextBox.Text) > -1)
{
 студентыDataGridView.Rows[j].Cells[i].Style.BackColor = 
Color.AliceBlue;
 студентыDataGridView.Rows[j].Cells[i].Style.ForeColor = 
Color.Blue;
 }
 }
 }
 }
 }
 private void CloseButton_Click(object sender, EventArgs e)
 {
 this.Close();
 }

//код на создание подсказок и автозаполнение с помощью коллекций значений
[System.ComponentModel.Browsable(true)]
public System.Windows.Forms.AutoCompleteMode AutoCompleteMode { get; set; }

    // Create the list to use as the custom source. 
    var source = new AutoCompleteStringCollection();
    source.AddRange(new string[]
                    {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                    });

    // Create and initialize the text box.
    var textBox = new TextBox
                  {
                      AutoCompleteCustomSource = source,
                      AutoCompleteMode = 
                          AutoCompleteMode.SuggestAppend,
                      AutoCompleteSource =
                          AutoCompleteSource.CustomSource,
                      Location = new Point(20, 20),
                      Width = ClientRectangle.Width - 40,
                      Visible = true
                  };

    // Add the text box to the form.
    Controls.Add(textBox);
}

//установка минимального размера формы
private void Form1_Load(object sender, EventArgs e)
{
    this.MinimumSize = new Size(250, 250);
}


1. Триггер, который будет отслеживать добавление записей в
таблице Студенты и оповещать об этом пользователя.
Листинг 4.6.1 – SQL код Индикатора добавления
USE [student_Kalayda]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Индикатор добавления]
 ON [dbo].[Студенты]
 AFTER INSERT
AS 
BEGIN
SET NOCOUNT ON;
 PRINT 'Запись добавлена'
END



2. Триггер, который будет отслеживать обновление записей в
таблице Студенты и оповещать об этом пользователя.
Листинг 4.6.2 – SQL код Индикатора изменения
USE [student_Kalayda]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Индикатор изменения] 
 ON [dbo].[Студенты]
 AFTER UPDATE
AS 
BEGIN
SET NOCOUNT ON;
 PRINT 'Запись изменена'
END


3. Триггер, который будет отслеживать удаление записей в таблице
31
Студенты и оповещать об этом пользователя.
Листинг 4.6.3 – SQL код Индикатора удаления
USE [student_Kalayda]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Индикатор удаления]
 ON [dbo].[Студенты]
 AFTER DELETE
AS 
BEGIN
SET NOCOUNT ON;
 PRINT 'Запись удалена'
END

//возможная реализация счётчика
textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text)+1);

https://learn.microsoft.com/ru-ru/visualstudio/data-tools/create-a-simple-data-application-by-using-adonet?view=vs-2022&tabs=csharp

https://www.internet-technologies.ru/articles/sozdanie-form-registracii-i-avtorizacii-na-php.html


//возможная реализация входа по логину
         public string login = "Admin";
        public string password = "260575";
        public string loginuser = "User";
        public string passworduser = "12345";


        public Login()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            if ((LoginTextBox.Text == login) && (PasswordTextBox.Text == password))
            {
                Program.ps = PasswordTextBox.Text;
                Program.lg = LoginTextBox.Text;
                Form1 MyFormMain = new Form1();
                MyFormMain.Show();
               
                
            }
            else if ((LoginTextBox.Text == loginuser) && (PasswordTextBox.Text == passworduser))
            {
                Program.ps = PasswordTextBox.Text;
                Program.lg = LoginTextBox.Text;
                Sort MyFormMain = new Sort();
                MyFormMain.Show();
               
            }
            else MessageBox.Show("Неверный пароль или логин");

        }
 
 */