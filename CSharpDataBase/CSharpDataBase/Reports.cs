using System;
using System.Data;

using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace CSharpDataBase
{
	public class Reports
	{
		public Reports()
		{
		}

		public void ShowReport(DataTable dtForReport,string path)
		{
			#region myVariable

			ParameterFields paramFields=new ParameterFields();

			ParameterField paramField1=new ParameterField();
			ParameterDiscreteValue discreteVal1=new ParameterDiscreteValue();

			ParameterField paramField2=new ParameterField();
			ParameterDiscreteValue discreteVal2=new ParameterDiscreteValue();

			ParameterField paramField3=new ParameterField();
			ParameterDiscreteValue discreteVal3=new ParameterDiscreteValue();

			ParameterField paramField4=new ParameterField();
			ParameterDiscreteValue discreteVal4=new ParameterDiscreteValue();

			ParameterField paramField5=new ParameterField();
			ParameterDiscreteValue discreteVal5=new ParameterDiscreteValue();

			ParameterValues paramValues=new ParameterValues();
			
			DataBase db=new DataBase();
			DataTable dt=new DataTable();
	
			#endregion

			#region AddParameters
			paramField1.ParameterFieldName = "Date";
			discreteVal1.Value = DateTime.Now;
			paramField1.CurrentValues.Add(discreteVal1);
			paramFields.Add(paramField1);

			paramField2.ParameterFieldName = "Time";
			discreteVal2.Value = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
			paramField2.CurrentValues.Add(discreteVal2);
			paramFields.Add(paramField2);

			dt =db.MySelect("select name from sherkat");
			paramField3.ParameterFieldName = "sazman";
			discreteVal3.Value = dt.Rows[0][0].ToString().Trim();
			paramField3.CurrentValues.Add(discreteVal3);
			paramFields.Add(paramField3);

			frmReports f=new frmReports();
			f.crystalReportViewer1.ParameterFieldInfo = paramFields;
			#endregion

			#region ShowReport

			f.reportDocument1.Load(path);
			f.reportDocument1.SetDataSource(dtForReport);
			f.crystalReportViewer1.ReportSource = f.reportDocument1;
			f.ShowDialog();
			#endregion
		}
	}
}
