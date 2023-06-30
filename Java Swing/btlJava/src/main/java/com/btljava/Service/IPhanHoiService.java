/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.phanhoi;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IPhanHoiService {
    public boolean insert(phanhoi ph) throws Exception;
    
    public boolean update(phanhoi ph) throws Exception;
    
    public boolean delete(String ph) throws Exception;
    
    public List<phanhoi> findAll(int s) throws Exception;
    
    public phanhoi findbyid(int s) throws Exception;
    
    public List<phanhoi> timkiem(String s) throws Exception;
}
