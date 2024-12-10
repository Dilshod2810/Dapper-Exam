create table schools
(
    school_id serial primary key,
    school_title varchar(50),
    level_count int,
    is_active int,
    created_at date default current_date,
    updated_at date default current_date
);


create table Students
(
    student_id serial primary key,
    student_code varchar(12),
    student_full_name varchar(50),
    gender int,
    dob date default current_date,
    email varchar(75) unique,
    phone varchar(15) unique,
    school_id int references schools(school_id),
    stage int,
    section varchar(2),
    is_active int,
    join_date date default current_date,
    created_at date default current_date,
    updated_at date default current_date
);

create table subjects
(
    subject_id serial primary key,
    title varchar(100),
    school_id int references schools(school_id),
    stage int,
    team int,
    carry_mark int,
    created_at date default current_date,
    updated_at date default current_date
);

create table parents
(
    parent_id serial primary key,
    parent_code varchar(12),
    parent_full_name varchar(50),
    email varchar(100) unique,
    phone varchar(20) unique,
    created_at date default current_date,
    updated_at date default current_date
);

create table studentparents
(
    student_parent_id serial primary key,
    student_id int references students(student_id),
    parent_id int references parents(parent_id),
    relationship int
);

create table classrooms
(
    classroom_id serial primary key,
    capacity int,
    room_type int,
    description varchar(100),
    created_at date default current_date,
    updated_at date default current_date
);

create table teachers
(
    teacher_id serial primary key,
    teacher_code varchar(12),
    teacher_full_name varchar(75),
    gender int,
    dob date default current_date,
    email varchar(75) unique,
    phone varchar(15) unique,
    is_active int,
    join_date date default current_date,
    working_days int,
    created_at date default current_date,
    updated_at date default current_date
);

create table classes
(
    class_id serial primary key,
    class_name varchar(50),
    subject_id int references subjects(subject_id),
    teacher_id int references teachers(teacher_id),
    classroom_id int references classrooms(classroom_id),
    section varchar(2),
    created_at date default current_date,
    updated_at date default current_date
);

create table classstudents
(
    class_student_id serial primary key,
    class_id int references classes(class_id),
    student_id int references students(student_id)
);
