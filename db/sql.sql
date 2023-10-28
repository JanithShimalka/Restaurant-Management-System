create database resturent;
use resturent;

create table users(
userid int primary key,
username varchar(50) not null,
upass varchar(10) not null,
uname varchar(50) not null,
uphone varchar(15)
);

insert into users values ('1','admin','123','janith','+94767863772');