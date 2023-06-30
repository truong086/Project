/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.ILoaiGiuongService;
import com.btljava.Service.Impl.LoaiGiuongService;
import com.btljava.daos.ILoaiGiuong;
import com.btljava.dao.impl.loaigiuongDao;
import com.btljava.model.loaigiuong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class LoaiGiuongController {
    private ILoaiGiuongService dao;
    
    public LoaiGiuongController(){
        dao = new LoaiGiuongService();
    }
    
    
    public boolean insert(loaigiuong lg) throws Exception {
        return dao.insert(lg);
    }

    
    public boolean update(loaigiuong lg) throws Exception {
        return dao.update(lg);
    }

    
    public boolean delete(String lg) throws Exception {
        return dao.delete(lg);
    }

    
    public List<loaigiuong> findAll() throws Exception {
        return dao.findAll();
    }

    
    public loaigiuong findAllid(int id) throws Exception {
        return dao.findAllid(id);
    }

    
    public List<loaigiuong> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }
}
