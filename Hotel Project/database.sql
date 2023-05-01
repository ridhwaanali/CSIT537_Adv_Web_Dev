create table if not exists rooms( id integer primary key auto_increment, name text, status varchar(20));

create table if not exists reservation( id integer primary key auto_increment,name text, room_no integer, paid integer);

GRANT SELECT, INSERT, DELETE, UPDATE
ON johnsmithdatabase.*
TO johnsmith@localhost
IDENTIFIED BY ' johnsmithpass';
Once again, replace johnsmith with yourfirstnamelastname