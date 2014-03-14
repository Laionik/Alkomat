namespace Alkomat
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_usb_connect = new System.Windows.Forms.Button();
            this.button_draw_graph = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_get_data_from_file = new System.Windows.Forms.Button();
            this.port_number_label = new System.Windows.Forms.Label();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.logger = new System.Windows.Forms.TextBox();
            this.logger_label = new System.Windows.Forms.Label();
            this.port_number_box = new System.Windows.Forms.ComboBox();
            this.read_ports = new System.Windows.Forms.Button();
            this.button_usb_disconnect = new System.Windows.Forms.Button();
            this.baudrate_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arduino_value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // button_usb_connect
            // 
            this.button_usb_connect.Location = new System.Drawing.Point(12, 139);
            this.button_usb_connect.Name = "button_usb_connect";
            this.button_usb_connect.Size = new System.Drawing.Size(91, 23);
            this.button_usb_connect.TabIndex = 0;
            this.button_usb_connect.Text = "Połącz";
            this.button_usb_connect.UseVisualStyleBackColor = true;
            this.button_usb_connect.Click += new System.EventHandler(this.button_usb_connect_Click);
            // 
            // button_draw_graph
            // 
            this.button_draw_graph.Location = new System.Drawing.Point(12, 276);
            this.button_draw_graph.Name = "button_draw_graph";
            this.button_draw_graph.Size = new System.Drawing.Size(91, 23);
            this.button_draw_graph.TabIndex = 1;
            this.button_draw_graph.Text = "Rysuj wykres";
            this.button_draw_graph.UseVisualStyleBackColor = true;
            this.button_draw_graph.Click += new System.EventHandler(this.button_draw_graph_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(118, 38);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(458, 439);
            this.chart.TabIndex = 2;
            this.chart.Text = "Wykres";
            // 
            // button_get_data_from_file
            // 
            this.button_get_data_from_file.Location = new System.Drawing.Point(12, 225);
            this.button_get_data_from_file.Name = "button_get_data_from_file";
            this.button_get_data_from_file.Size = new System.Drawing.Size(91, 45);
            this.button_get_data_from_file.TabIndex = 3;
            this.button_get_data_from_file.Text = "Pobierz dane z pliku";
            this.button_get_data_from_file.UseVisualStyleBackColor = true;
            this.button_get_data_from_file.Click += new System.EventHandler(this.button_get_data_from_file_Click);
            // 
            // port_number_label
            // 
            this.port_number_label.AutoSize = true;
            this.port_number_label.Location = new System.Drawing.Point(12, 38);
            this.port_number_label.Name = "port_number_label";
            this.port_number_label.Size = new System.Drawing.Size(65, 13);
            this.port_number_label.TabIndex = 6;
            this.port_number_label.Text = "Numer portu";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(9, 78);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(97, 13);
            this.baudrate_label.TabIndex = 7;
            this.baudrate_label.Text = "Prędkość transmisji";
            // 
            // logger
            // 
            this.logger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.logger.Location = new System.Drawing.Point(582, 36);
            this.logger.Multiline = true;
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            this.logger.Size = new System.Drawing.Size(163, 441);
            this.logger.TabIndex = 8;
            // 
            // logger_label
            // 
            this.logger_label.AutoSize = true;
            this.logger_label.Location = new System.Drawing.Point(579, 9);
            this.logger_label.Name = "logger_label";
            this.logger_label.Size = new System.Drawing.Size(40, 13);
            this.logger_label.TabIndex = 9;
            this.logger_label.Text = "Logger";
            // 
            // port_number_box
            // 
            this.port_number_box.FormattingEnabled = true;
            this.port_number_box.Location = new System.Drawing.Point(12, 54);
            this.port_number_box.Name = "port_number_box";
            this.port_number_box.Size = new System.Drawing.Size(91, 21);
            this.port_number_box.TabIndex = 10;
            // 
            // read_ports
            // 
            this.read_ports.Location = new System.Drawing.Point(12, 12);
            this.read_ports.Name = "read_ports";
            this.read_ports.Size = new System.Drawing.Size(91, 23);
            this.read_ports.TabIndex = 11;
            this.read_ports.Text = "Wczytaj porty";
            this.read_ports.UseVisualStyleBackColor = true;
            this.read_ports.Click += new System.EventHandler(this.read_ports_Click);
            // 
            // button_usb_disconnect
            // 
            this.button_usb_disconnect.Location = new System.Drawing.Point(12, 168);
            this.button_usb_disconnect.Name = "button_usb_disconnect";
            this.button_usb_disconnect.Size = new System.Drawing.Size(88, 23);
            this.button_usb_disconnect.TabIndex = 13;
            this.button_usb_disconnect.Text = "Rozłącz";
            this.button_usb_disconnect.UseVisualStyleBackColor = true;
            this.button_usb_disconnect.Click += new System.EventHandler(this.button_usb_disconnect_Click);
            // 
            // baudrate_box
            // 
            this.baudrate_box.Location = new System.Drawing.Point(12, 94);
            this.baudrate_box.Name = "baudrate_box";
            this.baudrate_box.Size = new System.Drawing.Size(91, 20);
            this.baudrate_box.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wczytana wartość:";
            // 
            // arduino_value
            // 
            this.arduino_value.Location = new System.Drawing.Point(236, 12);
            this.arduino_value.Name = "arduino_value";
            this.arduino_value.ReadOnly = true;
            this.arduino_value.Size = new System.Drawing.Size(100, 20);
            this.arduino_value.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 489);
            this.Controls.Add(this.arduino_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudrate_box);
            this.Controls.Add(this.button_usb_disconnect);
            this.Controls.Add(this.read_ports);
            this.Controls.Add(this.port_number_box);
            this.Controls.Add(this.logger_label);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.baudrate_label);
            this.Controls.Add(this.port_number_label);
            this.Controls.Add(this.button_get_data_from_file);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.button_draw_graph);
            this.Controls.Add(this.button_usb_connect);
            this.Name = "Form1";
            this.Text = "AlkomatPC";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_usb_connect;
        private System.Windows.Forms.Button button_draw_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button_get_data_from_file;
        private System.Windows.Forms.Label port_number_label;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.TextBox logger;
        private System.Windows.Forms.Label logger_label;
        private System.Windows.Forms.ComboBox port_number_box;
        private System.Windows.Forms.Button read_ports;
        private System.Windows.Forms.Button button_usb_disconnect;
        private System.Windows.Forms.TextBox baudrate_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arduino_value;
    }
}

