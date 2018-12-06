select * from AspNetRoles;

select * from AspNetUserRoles;

select * from AspNetUsers;

insert into AspNetRoles(id, Name) values (1, 'instructor');
insert into AspNetRoles(id, Name) values (2, 'mentor');
insert into AspNetRoles(id, Name) values (3, 'student');

insert into AspNetUserRoles(UserId,RoleId) values (1,3);
insert into AspNetUserRoles(UserId,RoleId) values (2,2);
insert into AspNetUserRoles(UserId,RoleId) values (3,1);
insert into AspNetUserRoles(UserId,RoleId) values (4,3);
insert into AspNetUserRoles(UserId,RoleId) values (5,3);