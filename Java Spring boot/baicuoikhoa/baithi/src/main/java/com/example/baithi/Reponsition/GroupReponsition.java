package com.example.baithi.Reponsition;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import com.example.baithi.model.Access;

public interface GroupReponsition extends JpaRepository<Access, Integer>{
    @Query("select a from Access a where a.groupName like %:groupName%")
    List<Access> findCheck(@Param("groupName") String groupName);

    List<Access> findByGroupNameAndCreator(String groupName, String creator);

    @Query("select a from Access a where a.groupName = :groupName")
    Access checkGroup(@Param("groupName") String groupName);
}
