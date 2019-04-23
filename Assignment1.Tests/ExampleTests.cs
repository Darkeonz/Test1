using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using Xunit;

namespace Assignment1.Tests
{
	public class ExampleTests
	{

		[Fact]
		public void ArgInputDatasetA()
		{
			string[] arg = {};

			// Arrange
			string expected = "No numbers";

			// Act
			string actual = Example.GetStringResult(arg);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ArgInputDatasetB()
		{
			string[] arg = { "17" };
			// Arrange
			string expected = "Minimum = " + "17" + "; maximum = " + "17"; ;

			// Act
			string actual = Example.GetStringResult(arg);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ArgInputDatasetC()
		{
			string[] arg = { "27","29" };
			// Arrange
			string expected = "Minimum = " + "27" + "; maximum = " + "29"; ;

			// Act
			string actual = Example.GetStringResult(arg);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ArgInputDatasetD()
		{
			string[] arg = { "39", "37" };
			// Arrange
			string expected = "Minimum = " + "37" + "; maximum = " + "39"; ;

			// Act
			string actual = Example.GetStringResult(arg);

			// Assert
			Assert.NotEqual(expected, actual);
		}

		[Fact]
		public void ArgInputDatasetE()
		{
			string[] arg = { "49", "47", "48" };
			// Arrange
			string expected = "Minimum = " + "47" + "; maximum = " + "49"; ;

			// Act
			string actual = Example.GetStringResult(arg);

			// Assert
			Assert.NotEqual(expected, actual);
		}
	}

	// string[] arg = new string[] { "A", "B", "C", "D", "E" };
}
