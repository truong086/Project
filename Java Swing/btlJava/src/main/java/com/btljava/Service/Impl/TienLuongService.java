/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.ITienLuongService;
import com.btljava.daos.Itienluong;
import com.btljava.dao.impl.tienluongDao;
import com.btljava.model.tienluong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class TienLuongService implements ITienLuongService{
    
    private Itienluong dao;
    
    public TienLuongService(){
        dao = new tienluongDao();
    }
    
    @Override
    public boolean insert(tienluong tl) throws Exception {
        return dao.insert(tl);
    }

    @Override
    public boolean update(tienluong tl) throws Exception {
        return dao.update(tl);
    }

    @Override
    public boolean delete(String tl) throws Exception {
        return dao.delete(tl);
    }

    @Override
    public List<tienluong> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<tienluong> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public tienluong findby(String s) throws Exception {
        return dao.findby(s);
    }

    @Override
    public tienluong findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
    
}
