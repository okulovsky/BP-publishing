using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Slide05
{
	
	public class Program
	{
		public static Func<double,double> Derivative(Func<double,double> f)
		{
			var eps=1e-10;
			return x => (f(x + eps) - f(x)) / eps;
		}

		public static Series BuildGraph(Func<double,double> f)
		{
			var series = new Series() { ChartType = SeriesChartType.FastLine };
			for (double x = 0; x < 1; x += 0.01)
				series.Points.Add(new DataPoint(x, f(x)));
			return series;
		}

		
		static void Main()
		{
			Func<double, double> function = x => x * x;
			var chart = new Chart();
			chart.ChartAreas.Add(new ChartArea());
			chart.Series.Add(BuildGraph(function));
			chart.Series.Add(BuildGraph(Derivative(function)));
			var form = new Form();
			chart.Dock = DockStyle.Fill;
			form.Controls.Add(chart);
			Application.Run(form);
		}


	}
}