namespace MarkupClass
{
	partial class HelpForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._txtHelp = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _txtHelp
			// 
			this._txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._txtHelp.Location = new System.Drawing.Point(3, 1);
			this._txtHelp.Name = "_txtHelp";
			this._txtHelp.ReadOnly = true;
			this._txtHelp.Size = new System.Drawing.Size(263, 202);
			this._txtHelp.TabIndex = 0;
			this._txtHelp.Text = "Горячие клавишы назначения классов:\n1 - Car\n2 - CarWithTrailer\n3 - MiniTruck\n4 - " +
    "Truck\n5 - BigTruck\n6 - Hauler\n7 - MiniBus\n8 - Bus\n9 - LongBus\n0 - Bike\n- - Speci" +
    "alCar\n= - EmergencyCar";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(3, 209);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(263, 74);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "Остальные горячие клавишы:\n-> - переход к следующей картинке\n<- - переход к преды" +
    "дущей картинке\ns - сохранить проект\ng - генерация выборки";
			// 
			// richTextBox2
			// 
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Location = new System.Drawing.Point(3, 289);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.Size = new System.Drawing.Size(263, 88);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "Обратите внимание, что:\n- генерация создает файл с разметкой в формате CSV.\n- ген" +
    "рация удаляет все картинки, которые не были размечены в папке.\n- авто сохранения" +
    " нет.";
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 386);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this._txtHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HelpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Help";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _txtHelp;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}