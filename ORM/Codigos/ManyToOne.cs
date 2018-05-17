/*
 * Created by SharpDevelop.
 * User: Franco
 * Date: 21/02/2018
 * Time: 11:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NHibernate;
using ORM.Service;
using ORM.Entities;

namespace ORM
{
	/// <summary>
	/// Description of ManyToOne.
	/// </summary>
	public class ManyToOne
	{
		ISession sesion;
		
		public ManyToOne(ISession session)
		{
			this.sesion = session;
		}
		
		}
	
}
