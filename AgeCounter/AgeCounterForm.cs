﻿using AgeCounter.Models;
using System.Timers;

namespace AgeCounter;

public partial class AgeCounterForm : Form
{
    public CounterModel Counter { get; set; }
    private System.Timers.Timer _timer;

    public AgeCounterForm(CounterModel counterModel)
    {
        InitializeComponent();
        Counter = counterModel;
        AgeCounterLabel.Text = $"{(Counter.Year < 10 ? "0" + Counter.Year : Counter.Year)}:{(Counter.Day < 10 ? "0" + Counter.Day : Counter.Day)}:{(Counter.Hour < 10 ? "0" + Counter.Hour : Counter.Hour)}:{(Counter.Minute < 10 ? "0" + Counter.Minute : Counter.Minute)}:{(Counter.Second < 10 ? "0" + Counter.Second : Counter.Second)}";
        ProgressBar.Value = (Counter.Year * 365) + Counter.Day;
        _timer = new System.Timers.Timer();
        _timer.Interval = 1000;
        _timer.Elapsed += Timer_Elapsed;
        _timer.Start();
    }

    private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        Invoke(() =>
        {
            Counter.Second++;
            if (Counter.Second == 60)
            {
                Counter.Second = 0;
                Counter.Minute++;
            }
            if (Counter.Minute == 60)
            {
                Counter.Minute = 0;
                Counter.Hour++;
            }
            if (Counter.Hour == 24)
            {
                Counter.Hour = 0;
                Counter.Day++;
                ProgressBar.Value++;
            }
            if (Counter.Day == 365)
            {
                Counter.Day = 1;
                Counter.Year++;
            }
            AgeCounterLabel.Text = $"{(Counter.Year < 10 ? "0" + Counter.Year : Counter.Year)}:{(Counter.Day < 10 ? "0" + Counter.Day : Counter.Day)}:{(Counter.Hour < 10 ? "0" + Counter.Hour : Counter.Hour)}:{(Counter.Minute < 10 ? "0" + Counter.Minute : Counter.Minute)}:{(Counter.Second < 10 ? "0" + Counter.Second : Counter.Second)}";
            ProgressBar.Value = (Counter.Year * 365) + Counter.Day;
        });
    }

    private void AgeCounterForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _timer.Stop();
        _timer.Dispose();
        MainForm.Form.Show();
    }

    private void AgeCounterLabel_DoubleClick(object sender, EventArgs e)
    {
        this.ShowInTaskbar = false;
        this.ShowIcon = false;
        NotifyIcon.Visible = true;
        var path = Application.StartupPath + "\\Icons\\noun-hourglass-527930.ico";
        NotifyIcon.Icon = new Icon(path);
        NotifyIcon.BalloonTipTitle = "Age Counter";
        NotifyIcon.BalloonTipText = "The app was hidden";
        NotifyIcon.BalloonTipIcon = ToolTipIcon.None;
        NotifyIcon.ShowBalloonTip(1000);
    }

    private void NotifyIcon_Click(object sender, EventArgs e)
    {
        var screen = Screen.PrimaryScreen.WorkingArea;
        this.Location = new Point((screen.Width - this.Width) / 2, (screen.Height - this.Height) / 2);
        this.ShowInTaskbar = true;
        this.ShowIcon = true;
    }
}
