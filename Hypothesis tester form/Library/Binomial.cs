using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothesis_tester_core
{
	public static class Binomial
	{
		public static event EventHandler Computed;

		/// <summary>
		/// This will perform a binomial hypothesis test.
		/// </summary>
		/// <param name="sampleSuccess">How many were successful</param>
		/// <param name="n"></param>
		/// <param name="p"></param>
		/// <param name="tail">Perform test on upper or lower tail</param>
		/// <param name="signLevel">Significance level.</param>
		/// <returns>True means that there is enough evidence to reject the null hypothesis.</returns>
		public static bool HypoTest(int sampleSuccess, int n, double p, AlternateHypo tail, double signLevel)
		{
			try
			{
				int[] x = Enumerable.Range(0, n + 1).ToArray();
				BinomialDistribution distribution = new BinomialDistribution(n, p);

				switch (tail)
				{
					case AlternateHypo.LessThan:
						{
							int criticalRegion = x.AsParallel()
										.Where(num => distribution.DistributionFunction(num) < signLevel)
										.OrderBy(num => num)
										.First();

							if (sampleSuccess <= criticalRegion)
								return true;
							else
								return false;
						}

					default:
						{
							int criticalRegion = x.AsParallel()
										.Where(num => (1 - distribution.DistributionFunction(num)) < signLevel)
										.OrderBy(num => num)
										.First();

							if (sampleSuccess >= criticalRegion)
								return true;
							else
								return false;
						}
				}

			}
			catch (InvalidOperationException)
			{
				return false; //Because there is no evidence at all.
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// This is the same as the above method except that there are two tails.
		/// </summary>
		/// <param name="sampleSuccess"></param>
		/// <param name="n"></param>
		/// <param name="p"></param>
		/// <param name="signLevel"></param>
		/// <returns></returns>
		public static bool HypoTest(int sampleSuccess, int n, double p, double signLevel)
		{
			try
			{
				double lowerTail = signLevel / 2;
				double upperTail = 1 - lowerTail;

				int[] x = Enumerable.Range(0, n + 1).ToArray();
				BinomialDistribution distribution = new BinomialDistribution(n, p);

				int lowerCriticalRegion = x.AsParallel()
									.Where(num => distribution.DistributionFunction(num) < signLevel)
									.OrderBy(num => num)
									.First();
				int upperCriticalRegion = x.AsParallel()
										.Where(num => (1 - distribution.DistributionFunction(num)) < signLevel)
										.OrderBy(num => num)
										.First();

				if ((sampleSuccess <= lowerCriticalRegion) || (sampleSuccess >= upperCriticalRegion))
					return true;
				else
					return false;
			}
			catch (InvalidOperationException)
			{
				return false; //Because there is no evidence at all.
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
