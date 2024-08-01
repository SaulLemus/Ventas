
use ventas

select * from tbl_prv_ingreso

-- truncate table tbl_cli_cotiza
-- truncate table tbl_cli_cotiza_det
-- truncate table tbl_cli_pedido
-- truncate table tbl_cli_pedido_det
-- truncate table tbl_cli_factura
-- truncate table tbl_cli_factura_det

-- truncate table tbl_prv_pedido
-- truncate table tbl_prv_pedido_det
-- truncate table tbl_prv_ingreso
-- truncate table tbl_prv_ingreso_det
-- truncate table tbl_prv_factura
-- truncate table tbl_prv_factura_det

-- truncate table tbllog_operacion

select * from tbl_correlativo

--update tbl_correlativo set numerosiguiente =1 

select * from tbl_almacen
select * from tbl_almacendet

--update tbl_almacendet set existencia = 0, costo = 0.0

--Evaluar como debe manejarse el costo, en el articulo o en el almacen
select * from tbl_articulo
--update tbl_articulo set precio_costo=0.0




