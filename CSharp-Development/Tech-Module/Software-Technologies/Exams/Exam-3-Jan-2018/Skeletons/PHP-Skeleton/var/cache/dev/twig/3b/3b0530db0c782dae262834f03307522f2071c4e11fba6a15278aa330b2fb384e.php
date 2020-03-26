<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_607e7331f893799e32e62e782ae917af38fe16fe051688b7594c3115509d6341 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_607e7331f893799e32e62e782ae917af38fe16fe051688b7594c3115509d6341->enter($__internal_607e7331f893799e32e62e782ae917af38fe16fe051688b7594c3115509d6341_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_de826067a8101b83d00915e7b003093579436ebbc7e8893acf0b71dbd3b5daa0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_de826067a8101b83d00915e7b003093579436ebbc7e8893acf0b71dbd3b5daa0->enter($__internal_de826067a8101b83d00915e7b003093579436ebbc7e8893acf0b71dbd3b5daa0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_607e7331f893799e32e62e782ae917af38fe16fe051688b7594c3115509d6341->leave($__internal_607e7331f893799e32e62e782ae917af38fe16fe051688b7594c3115509d6341_prof);

        
        $__internal_de826067a8101b83d00915e7b003093579436ebbc7e8893acf0b71dbd3b5daa0->leave($__internal_de826067a8101b83d00915e7b003093579436ebbc7e8893acf0b71dbd3b5daa0_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_e72b0b6c9e900e3c79e273d4c2215388f8bb94e227c1e6e029bc7578bf7f67cb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e72b0b6c9e900e3c79e273d4c2215388f8bb94e227c1e6e029bc7578bf7f67cb->enter($__internal_e72b0b6c9e900e3c79e273d4c2215388f8bb94e227c1e6e029bc7578bf7f67cb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_30e0934b56bd208bd432dba6cc6dbb75dd2050f04207258301799bb5bde4e3a2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_30e0934b56bd208bd432dba6cc6dbb75dd2050f04207258301799bb5bde4e3a2->enter($__internal_30e0934b56bd208bd432dba6cc6dbb75dd2050f04207258301799bb5bde4e3a2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_30e0934b56bd208bd432dba6cc6dbb75dd2050f04207258301799bb5bde4e3a2->leave($__internal_30e0934b56bd208bd432dba6cc6dbb75dd2050f04207258301799bb5bde4e3a2_prof);

        
        $__internal_e72b0b6c9e900e3c79e273d4c2215388f8bb94e227c1e6e029bc7578bf7f67cb->leave($__internal_e72b0b6c9e900e3c79e273d4c2215388f8bb94e227c1e6e029bc7578bf7f67cb_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_df9b6afcac32b59f700cacfa451ab1fce73ba50568338e3b3300ea7ac7b01244 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_df9b6afcac32b59f700cacfa451ab1fce73ba50568338e3b3300ea7ac7b01244->enter($__internal_df9b6afcac32b59f700cacfa451ab1fce73ba50568338e3b3300ea7ac7b01244_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_8a0e01d66389cf98ade0e4792fd80e685969831ac5a5a19bd37de43fea115905 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8a0e01d66389cf98ade0e4792fd80e685969831ac5a5a19bd37de43fea115905->enter($__internal_8a0e01d66389cf98ade0e4792fd80e685969831ac5a5a19bd37de43fea115905_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_8a0e01d66389cf98ade0e4792fd80e685969831ac5a5a19bd37de43fea115905->leave($__internal_8a0e01d66389cf98ade0e4792fd80e685969831ac5a5a19bd37de43fea115905_prof);

        
        $__internal_df9b6afcac32b59f700cacfa451ab1fce73ba50568338e3b3300ea7ac7b01244->leave($__internal_df9b6afcac32b59f700cacfa451ab1fce73ba50568338e3b3300ea7ac7b01244_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_f1313472600c8b46609189af4e6a5fa704f834179fe94bbd279354cb1ba1e29d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f1313472600c8b46609189af4e6a5fa704f834179fe94bbd279354cb1ba1e29d->enter($__internal_f1313472600c8b46609189af4e6a5fa704f834179fe94bbd279354cb1ba1e29d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_12990cdf99c3ab6b2ab79ec686d2533d01e0cebd99abf9c96ed39d733fdce164 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_12990cdf99c3ab6b2ab79ec686d2533d01e0cebd99abf9c96ed39d733fdce164->enter($__internal_12990cdf99c3ab6b2ab79ec686d2533d01e0cebd99abf9c96ed39d733fdce164_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_12990cdf99c3ab6b2ab79ec686d2533d01e0cebd99abf9c96ed39d733fdce164->leave($__internal_12990cdf99c3ab6b2ab79ec686d2533d01e0cebd99abf9c96ed39d733fdce164_prof);

        
        $__internal_f1313472600c8b46609189af4e6a5fa704f834179fe94bbd279354cb1ba1e29d->leave($__internal_f1313472600c8b46609189af4e6a5fa704f834179fe94bbd279354cb1ba1e29d_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
