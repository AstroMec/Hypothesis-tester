using System;
using System.Runtime.CompilerServices;
using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using NumSharp;

namespace Hypothesis_tester_core
{
	public static class Normal
	{
		public static event EventHandler Computed;

		/// <summary>
		/// This will compute the mean of a data set.
		/// </summary>
		/// <param name="data"></param>
		/// <returns>Returns null if there is no data.</returns>
		public static double? Mean(double[] data)
		{
			try
			{
				return np.mean(np.array(data));
			}
			catch (InvalidOperationException)
			{
				return null;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// This will perform a normal distribution hypothesis test.
		/// </summary>
		/// <param name="meanOfSample">This represents the mean of the test population sample</param>
		/// <param name="mu"></param>
		/// <param name="sigma"></param>
		/// <param name="n">The quantity of the sample.</param>
		/// <param name="signLevel">The significance level of the test</param>
		/// <returns>True means that there is enough evidence to suggest that the mean of the population has 
		/// changed.</returns>
		public static bool NormalHypoTest(double meanOfSample, double mu, double sigma, int n, double signLevel = 0.05)
		{
			try
			{
				double lowerTail = signLevel / 2;
				double upperTail = 1 - lowerTail;
				double lowerCritRegion = new NormalDistribution(mu, sigma / Math.Sqrt(n)).InverseDistributionFunction(lowerTail);
				double upperCritRegion = new NormalDistribution(mu, sigma / Math.Sqrt(n)).InverseDistributionFunction(upperTail);

				if ((meanOfSample < lowerCritRegion) || (meanOfSample > upperCritRegion))
					return true;
				else
					return false;
			}
			catch (InvalidOperationException)
			{
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// This will perform the same as the above method except that it will take the raw 
		/// data instead. 
		/// </summary>
		/// <param name="data"></param>
		/// <param name="mu"></param>
		/// <param name="sigma"></param>
		/// <param name="n"></param>
		/// <param name="signLevel"></param>
		/// <returns></returns>
		public static bool NormalHypoTest(double[] data, double mu, double sigma, int n, double signLevel = 0.05)
		{
			try
			{
				double? mean = Mean(data);

				if (mean != null)
				{
					return NormalHypoTest((double)mean, mu, sigma, n, signLevel); 
				}
				else
				{
					throw new InvalidOperationException();
				}
			}
			catch (InvalidOperationException)
			{
				return true;
			}
			catch
			{
				throw;
			}
		}

		public static bool OneTailNormalHypoTest(double meanOfSample, double mu, double sigma, int n, double signLevel = 0.05, 
			AlternateHypo tail = AlternateHypo.GreaterThan)
		{
			try
			{
				switch (tail)
				{
					case AlternateHypo.GreaterThan:
						double upperTail = signLevel;
						double upperCritRegion = new NormalDistribution(mu, sigma / Math.Sqrt(n)).InverseDistributionFunction(upperTail);

						if (meanOfSample > upperCritRegion)
							return true;
						else
							return false;
						

					default:
						double lowerTail = signLevel;
						double lowerCritRegion = new NormalDistribution(mu, sigma / Math.Sqrt(n)).InverseDistributionFunction(lowerTail);

						if (meanOfSample < lowerCritRegion)
							return true;
						else
							return false;
				}
			}
			catch (InvalidOperationException)
			{
				return true;
			}
			catch
			{
				throw;
			}
		}

		public static bool OneTailNormalHypoTest(double[] data, double mu, double sigma, int n, double signLevel = 0.05, 
			AlternateHypo tail = AlternateHypo.GreaterThan)
		{
			try
			{
				double? mean = Mean(data);

				if (mean != null)
					return OneTailNormalHypoTest((double)mean, mu, sigma, n, signLevel, tail);
				else
					throw new InvalidOperationException();
			}
			catch (InvalidOperationException)
			{
				return true;
			}
			catch
			{
				throw;
			}
		}

		public static void HasComputed(object sender, EventArgs e)
		{
			Computed(sender, e);
		}
	}
}
