/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 17/5/2018
 * Time: 9:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ORM.Entities
{
	/// <summary>
	/// Description of Contacto.
	/// </summary>
	public class Contacto
	{
		
		private int codigo;
		private string _descripcion;
		
		public virtual int Codigo{
			get{return codigo;}
			set{codigo = value;}
		}	
		public virtual string Descripcion{
			get{return _descripcion;}
			set{_descripcion = value;}
		}
		
		//
		
		private ICollection<Email> emails;
		
		public virtual ICollection<Email> Emails{
			get{return emails;}
			set{emails = value;}
		}
	
		public Contacto()
		{
			emails = new List<Email>();
		}
	}
}
