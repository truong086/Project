package com.example.baithi.Reponsition;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import com.example.baithi.model.User;


public interface UserReponsition extends JpaRepository<User, Long>{
    @Query("select a from User a where a.fullname like %:fullname%")
    List<User> findCheck(@Param("fullname") String fullname);

    @Query("select a from User a where a.fullname = :fullname")
    User checkGroup(@Param("fullname") String fullname);
    
    @Query("select a from User a order by a.fullname desc")
    List<User> sapxep();
}
