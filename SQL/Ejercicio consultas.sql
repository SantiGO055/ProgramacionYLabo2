--1)
/*
select * from Provincia
*/
--2)
/*
select * from Provincia as A
where A.descripcion like '_u%'
*/

--3)
select * from Provincia as a
inner join Localidad as b
on a.id = 23

