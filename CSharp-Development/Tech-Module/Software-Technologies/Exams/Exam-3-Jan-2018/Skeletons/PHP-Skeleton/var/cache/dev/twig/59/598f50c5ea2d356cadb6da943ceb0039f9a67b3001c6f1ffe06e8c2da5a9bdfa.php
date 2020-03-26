<?php

/* project/delete.html.twig */
class __TwigTemplate_e96ae7270a11341b1876afd5543a20b46b73c0030e5df66a9382e05bce8babd9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/delete.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6a49637945a49d1ca99a6f7d6b9dec6ee2a37a47493839b5b6f567aa93abb837 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6a49637945a49d1ca99a6f7d6b9dec6ee2a37a47493839b5b6f567aa93abb837->enter($__internal_6a49637945a49d1ca99a6f7d6b9dec6ee2a37a47493839b5b6f567aa93abb837_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/delete.html.twig"));

        $__internal_7193c35539e3d542b5a416486347868a297eec309d1a981a51bdae624f21d29f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7193c35539e3d542b5a416486347868a297eec309d1a981a51bdae624f21d29f->enter($__internal_7193c35539e3d542b5a416486347868a297eec309d1a981a51bdae624f21d29f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6a49637945a49d1ca99a6f7d6b9dec6ee2a37a47493839b5b6f567aa93abb837->leave($__internal_6a49637945a49d1ca99a6f7d6b9dec6ee2a37a47493839b5b6f567aa93abb837_prof);

        
        $__internal_7193c35539e3d542b5a416486347868a297eec309d1a981a51bdae624f21d29f->leave($__internal_7193c35539e3d542b5a416486347868a297eec309d1a981a51bdae624f21d29f_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_697402f6e8d35272d1d2f7ff7dc56e4534a9dba4c955f9f0925a0bbac3228f66 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_697402f6e8d35272d1d2f7ff7dc56e4534a9dba4c955f9f0925a0bbac3228f66->enter($__internal_697402f6e8d35272d1d2f7ff7dc56e4534a9dba4c955f9f0925a0bbac3228f66_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_f590f4168119210a9d5229a71fcdd00530e86f2958e9b51b6290a0043026d1e1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f590f4168119210a9d5229a71fcdd00530e86f2958e9b51b6290a0043026d1e1->enter($__internal_f590f4168119210a9d5229a71fcdd00530e86f2958e9b51b6290a0043026d1e1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"
                      disabled=\"disabled\">";
        // line 16
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 20
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\"
                   disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 28
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_f590f4168119210a9d5229a71fcdd00530e86f2958e9b51b6290a0043026d1e1->leave($__internal_f590f4168119210a9d5229a71fcdd00530e86f2958e9b51b6290a0043026d1e1_prof);

        
        $__internal_697402f6e8d35272d1d2f7ff7dc56e4534a9dba4c955f9f0925a0bbac3228f66->leave($__internal_697402f6e8d35272d1d2f7ff7dc56e4534a9dba4c955f9f0925a0bbac3228f66_prof);

    }

    public function getTemplateName()
    {
        return "project/delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  84 => 28,  73 => 20,  66 => 16,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"
                      disabled=\"disabled\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\"
                   disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "project/delete.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\app\\Resources\\views\\project\\delete.html.twig");
    }
}
