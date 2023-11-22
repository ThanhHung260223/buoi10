use cauhoi

create table dap_an
(
	id  int,
	txt char(10),
	CONSTRAINT pk_dapan PRIMARY KEY (id),
	CONSTRAINT FK_dapan FOREIGN KEY (id) REFERENCES cauhoi(id)
)

select txt from cauhoi where id =1 