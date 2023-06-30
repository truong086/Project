/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IPhanHoiService;
import com.btljava.Service.Impl.PhanHoiService;
import com.btljava.daos.IPhanHoi;
import com.btljava.dao.impl.phanhoiDao;
import com.btljava.model.phanhoi;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class PhanHoiController {
    private IPhanHoiService dao;
    
    public PhanHoiController(){
        dao = new PhanHoiService();
    }
    
    public boolean insert(phanhoi ph) throws Exception {
        return dao.insert(ph);
    }

    
    public boolean update(phanhoi ph) throws Exception {
        return dao.update(ph);
    }

    
    public boolean delete(String ph) throws Exception {
        return dao.delete(ph);
    }

    
    public List<phanhoi> findAll(int s) throws Exception {
        return dao.findAll(s);
    }

    
    public phanhoi findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    
    public List<phanhoi> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }
}
