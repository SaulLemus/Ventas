

use ventas

select * from tbl_articulo where codigo ='20070300018' --orden:articulo 18

select * from tbl_prv_ingreso where orden = 157
select * from tbl_prv_ingreso_det where orden_articulo=18

select * from tbl_prv_ingreso where orden = 205
select * from tbl_prv_ingreso_det where orden_articulo=18

select * from tbl_cli_pedido where orden = 689
select * from tbl_cli_pedido_det where orden_articulo=18


select * from tbl_salida where orden_articulo = 18

select * from tbl_ingreso where orden_articulo = 18



select * from tbl_prv_ingreso where orden in (157,205)

select * from tbl_almacendet where orden_articulo=18


select * from tbl_correlativo

--va or 790 tipo PEDCLI









