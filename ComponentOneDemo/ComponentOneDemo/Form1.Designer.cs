
namespace ComponentOneDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            C1.Win.Input.C1CheckListItem c1CheckListItem4 = new C1.Win.Input.C1CheckListItem();
            C1.Win.Input.C1CheckListItem c1CheckListItem5 = new C1.Win.Input.C1CheckListItem();
            C1.Win.Input.C1CheckListItem c1CheckListItem6 = new C1.Win.Input.C1CheckListItem();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory11 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory12 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory13 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory14 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory15 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory16 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory17 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory18 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory19 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            C1.Win.ExpressionEditor.Model.ExpressionItemCategory expressionItemCategory20 = new C1.Win.ExpressionEditor.Model.ExpressionItemCategory();
            this.c1TaskDialog1 = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.c1CheckList1 = new C1.Win.Input.C1CheckList();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1CheckList1
            // 
            this.c1CheckList1.BindingInfo.DisplayMemberPath = "Name";
            this.c1CheckList1.BindingInfo.ValueMemberPath = "Value";
            this.c1CheckList1.BorderColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.c1CheckList1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1CheckList1.CheckImageList.ImageSize = new System.Drawing.Size(13, 13);
            this.c1CheckList1.CheckImageList.TransparentColor = System.Drawing.Color.Transparent;
            c1CheckListItem4.Value = "1";
            c1CheckListItem5.Value = "2";
            c1CheckListItem6.Value = "3";
            this.c1CheckList1.Items.Add(c1CheckListItem4);
            this.c1CheckList1.Items.Add(c1CheckListItem5);
            this.c1CheckList1.Items.Add(c1CheckListItem6);
            this.c1CheckList1.Location = new System.Drawing.Point(29, 64);
            this.c1CheckList1.Name = "c1CheckList1";
            this.c1CheckList1.SelectAllCaption = "Select All";
            this.c1CheckList1.ShowSelectAll = true;
            this.c1CheckList1.Size = new System.Drawing.Size(368, 794);
            this.c1CheckList1.TabIndex = 2;
            this.c1CheckList1.Text = "c1CheckList1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 21);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(435, 374);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(430, 126);
            this.c1ExpressionEditor1.TabIndex = 6;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            // 
            // c1ExpressionEditorPanel1
            // 
            expressionItemCategory12.Type = C1.Win.ExpressionEditor.Model.CategoryType.AggregateFuncs;
            expressionItemCategory13.Type = C1.Win.ExpressionEditor.Model.CategoryType.TextFuncs;
            expressionItemCategory14.Type = C1.Win.ExpressionEditor.Model.CategoryType.DateTimeFuncs;
            expressionItemCategory15.Type = C1.Win.ExpressionEditor.Model.CategoryType.LogicalFuncs;
            expressionItemCategory16.Type = C1.Win.ExpressionEditor.Model.CategoryType.MathFuncs;
            expressionItemCategory17.Type = C1.Win.ExpressionEditor.Model.CategoryType.ConvertFuncs;
            expressionItemCategory11.SubCategories.Add(expressionItemCategory12);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory13);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory14);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory15);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory16);
            expressionItemCategory11.SubCategories.Add(expressionItemCategory17);
            expressionItemCategory11.Type = C1.Win.ExpressionEditor.Model.CategoryType.Functions;
            expressionItemCategory18.Type = C1.Win.ExpressionEditor.Model.CategoryType.Operator;
            expressionItemCategory19.Type = C1.Win.ExpressionEditor.Model.CategoryType.Field;
            expressionItemCategory20.Type = C1.Win.ExpressionEditor.Model.CategoryType.Constant;
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory11);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory18);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory19);
            this.c1ExpressionEditorPanel1.Categories.Add(expressionItemCategory20);
            this.c1ExpressionEditorPanel1.ExpressionEditor = null;
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(435, 536);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(430, 322);
            this.c1ExpressionEditorPanel1.TabIndex = 7;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 891);
            this.Controls.Add(this.c1ExpressionEditorPanel1);
            this.Controls.Add(this.c1ExpressionEditor1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1CheckList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditorPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.C1Win7Pack.C1TaskDialog c1TaskDialog1;
        private C1.Win.Input.C1CheckList c1CheckList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
    }
}

