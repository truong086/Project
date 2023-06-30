/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IPhanHoiService;
import com.btljava.daos.IPhanHoi;
import com.btljava.dao.impl.phanhoiDao;
import com.btljava.model.phanhoi;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class PhanHoiService implements IPhanHoiService{
    
    private IPhanHoi dao;
    
    public  PhanHoiService(){
        dao = new phanhoiDao();
    }
    @Override
    public boolean insert(phanhoi ph) throws Exception {
        return dao.insert(ph);
    }

    @Override
    public boolean update(phanhoi ph) throws Exception {
        return dao.update(ph);
    }

    @Override
    public boolean delete(String ph) throws Exception {
        return dao.delete(ph);
    }

    @Override
    public List<phanhoi> findAll(int s) throws Exception {
        return dao.findAll(s);
    }

    @Override
    public phanhoi findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    @Override
    public List<phanhoi> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }
    
}
