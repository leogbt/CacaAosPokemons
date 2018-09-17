using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CacaAosPokemons;


namespace CacaAosPokemons.Tests
{
	[TestClass]
	public class PrincipalTeste
	{
		[TestMethod]
		public void IniciarCapturaTeste01()
		{
			Assert.AreEqual(Principal.IniciarCaptura("E"), 2);
		}

		[TestMethod]
		public void IniciarCapturaTeste02()
		{
			Assert.AreEqual(Principal.IniciarCaptura("NESO"), 4);
		}

		[TestMethod]
		public void IniciarCapturaTeste03()
		{
			Assert.AreEqual(Principal.IniciarCaptura("NSNSNS"), 2);
		}

		[TestMethod]
		public void IniciarCapturaTeste04()
		{
			Assert.AreEqual(Principal.IniciarCaptura("NSNSNSEEEO"), 5);
		}

	}
}
