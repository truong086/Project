/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.ILoaiGiuongService;
import com.btljava.daos.ILoaiGiuong;
import com.btljava.dao.impl.loaigiuongDao;
import com.btljava.model.loaigiuong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class LoaiGiuongService implements ILoaiGiuongService{
    private ILoaiGiuong dao;
    
    public LoaiGiuongService(){
        dao = new loaigiuongDao();
    }
    
    @Override
    public boolean insert(loaigiuong lg) throws Exception {
        return dao.insert(lg);
    }

    @Override
    public boolean update(loaigiuong lg) throws Exception {
        return dao.update(lg);
    }

    @Override
    public boolean delete(String lg) throws Exception {
        return dao.delete(lg);
    }

    @Override
    public List<loaigiuong> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public loaigiuong findAllid(int id) throws Exception {
        return dao.findAllid(id);
    }

    @Override
    public List<loaigiuong> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }
    
}
