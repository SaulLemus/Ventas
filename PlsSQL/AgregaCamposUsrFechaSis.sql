




/*  graba usuario al pedido*/
-- crear campo usuario y crear campo wusuario

use ventas
alter table tbl_cli_pedido add usuario nvarchar(25)
alter table tbl_cli_pedido add wusuario nvarchar(100)

alter table tbl_cli_factura add usuario nvarchar(25)
alter table tbl_cli_factura add wusuario nvarchar(100)

alter table tbl_prv_ingreso add usuario nvarchar(25)
alter table tbl_prv_ingreso add wusuario nvarchar(100)


/* OJO tbl_ingreso y tbl_salida create el campo fechasis con getdate de defaul */

alter table tbl_ingreso add fecha_sistema datetime not null default current_timestamp
alter table tbl_ingreso add usuario nvarchar(25)
alter table tbl_ingreso add wusuario nvarchar(100)

alter table tbl_salida add fecha_sistema datetime not null default current_timestamp
alter table tbl_salida add usuario nvarchar(25)
alter table tbl_salida add wusuario nvarchar(100)

alter table tbl_traslado add fecha_sistema datetime not null default current_timestamp
alter table tbl_traslado add usuario nvarchar(25)
alter table tbl_traslado add wusuario nvarchar(100)

alter table tbl_cli_factura add tipo_factura nvarchar(5) default 'A'



/*  tabla de log de operaciones */

USE [Ventas]
GO

/****** Object:  Table [dbo].[tbllog_operacion]    Script Date: 04/29/2018 15:32:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbllog_operacion](
	[orden] [int] IDENTITY(1,1) NOT NULL,
	[objeto] [int] NOT NULL,
	[orden_objeto] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[resultado] [nvarchar](100) NOT NULL,
	[usuario] [nvarchar](15) NOT NULL,
	[usuariow] [nvarchar](15) NOT NULL,
	[equipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbolog_operacion] PRIMARY KEY CLUSTERED 
(
	[orden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

