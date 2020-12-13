using CPF;
using CPF.Animation;
using CPF.Controls;
using CPF.Drawing;
using CPF.Shapes;
using CPF.Styling;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CPFApp
{
    public class Window1 : Window
    { 
        public DataGrid grdMain = null;
 
        protected override void InitializeComponent()
        {
            Title = "标题";
            Width = 500;
            Height = 1000;
            Background = null;
            grdMain = new DataGrid
            {
                Name = "grdMain",
                MarginLeft = 10,
                MarginTop = 50,
                Width = 300,
                Height = 800,
                Columns = new Collection<DataGridColumn>
                {
                    new DataGridTextColumn
                    {
                        Header="Name",
                        Binding=new DataGridBinding(nameof(DataItem.Name)) {BindingMode= BindingMode.TwoWay},
                        Width="200"
                    },
                },
                Bindings = { {nameof(DataGrid.Items), nameof(DataModel.Data) } }
            }; 
            
            Children.Add(new WindowFrame(this, new Panel
            {
                Width = "100%",
                Height = "100%",
                Children =
                {
                    new Button
                    { 
                        Content="按钮" ,Width = 100,MarginLeft = 10 ,MarginTop= 10 ,
                        Commands = {
                                        {
                                            nameof(Button.Click), DataLoad
                                        }
                                    },
                    },
                    grdMain
                }
            })) ;

            LoadStyleFile("res://CPFApp/Stylesheet1.css");//加载样式文件，文件需要设置为内嵌资源

            if (!DesignMode)//设计模式下不执行
            {

            }
        }

        public void DataLoad(CpfObject sender, object obj)
        {
            this.DataContext = new DataModel();
            
            // MessageBox.Show($"DataLoad Times [{(this.DataContext as DataModel).Times}] Milliseconds"); 
        }
    }

    public class DataItem 
    {
        public string Name { get; set; }
    }

    public class DataModel : CpfObject
    {
        public double Times { get; set; }
        
        public DataModel()
        {
            var st = Stopwatch.StartNew();
            Data = new Collection<DataItem>();
            for (int i = 0; i < 5000000; i++)
            { 
                Data.Add(new DataItem(){Name = $"Item {i}"});
            }
            
            st.Stop();
            this.Times = st.Elapsed.TotalMilliseconds;
        }

        public Collection<DataItem> Data 
         {
            get { return GetValue<Collection<DataItem>>(); }
            set { SetValue(value); }
        }
    }
}
