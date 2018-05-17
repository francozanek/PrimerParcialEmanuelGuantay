/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 17/5/2018
 * Time: 10:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ORM.Entities
{
	/// <summary>
	/// Description of email.
	/// </summary>
	public class Email
	{
		private int codigo;
		
		public virtual int Codigo{
			get{return codigo;}
			set{codigo = value;}
		}
			
		private string estado;
		
		public virtual string Estado{
			get{return estado;}
			set{estado = value;}
		}
		
		private DateTime fecha;
		
		public virtual DateTime Fecha{
			get{return fecha;}
			set{fecha = value;}
		}
		
		
		private Contacto contacto;
		
		public virtual Contacto Contacto{
			get{return contacto;}
			set{contacto = value;}
		}
		
		ICollection<Contacto> contactos;
		
		public virtual ICollection<Contacto> Contactos{
			get{return contactos;}
			set{contactos = value;}
		}
				
		public Email()
		{
			contactos= new List<Contacto>();
		}
		
	}
}
